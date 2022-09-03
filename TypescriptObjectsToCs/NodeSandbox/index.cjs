const ts = require("typescript");
const fs = require("fs");

const fileNames = ['./ts_example/timeSpan.ts','./ts_example/downloadSettings.ts'];
const output = fileNames.map(fileName => {
  const sourceFile = ts.createSourceFile(
    fileName,
    fs.readFileSync(fileName).toString(),
    ts.ScriptTarget.ESNext,
    /*setParentNodes */ false
  );

  removeRemoveKnownCyclicProps(sourceFile, 'obj');
  populateType(sourceFile);
  convertMapToArray(sourceFile);
  return sourceFile;
});

function removeRemoveKnownCyclicProps(obj, objName) {
  if (obj.hasOwnProperty('parent'))
    delete obj.parent;
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj === 'object')) {
      const propPath = objName + '.' + prop;
      removeRemoveKnownCyclicProps(obj[prop], propPath);
    }
  }
}

function populateType(obj, objName) {
  if(obj)
    obj._jstype = obj?.constructor.name.toString();
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object') && obj[prop].constructor) {
      const propPath = objName + '.' + prop;
      populateType(obj[prop], propPath);
    }
  }
}

function convertMapToArray(obj) {
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object')) {
      if(obj[prop] instanceof Map) {
        obj[prop] = Object.fromEntries(obj[prop].entries());
      }
      if(obj[prop] instanceof Set) {
        console.log('Set!');
      }
      convertMapToArray(obj[prop]);
    }
  }
}

fs.writeFileSync('output.json', JSON.stringify(output, null, 2));

module.exports = function (callback, filePath) {
  callback(null, output);
};
