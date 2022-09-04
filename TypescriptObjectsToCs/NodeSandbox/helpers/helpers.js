const ts = require('typescript');

/**
 * Use this to remove `parent` property from NodeObjects, otherwise I can't serialize sourceFile 
 * (can't use open-source options, bucausee they require types to be 'registered' and I don't know how to reference to them as they inside of `ts`)
 * @param {any} obj object to remove property
 * @param {string} objName used to output properties path
 */
function removeRemoveKnownCyclicProps(obj, objName) {
  // console.log(objName);
  if (obj.hasOwnProperty('parent'))
    delete obj.parent;
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object')) {
      const propPath = objName + '.' + prop;
      removeRemoveKnownCyclicProps(obj[prop], propPath);
    }
  }
}

/**
 * Populates `_type` property in objects to understand class name of object on NET side
 * @param {any} obj object to populate type
 * @param {string} objName used to output properties path
 */
function populateType(obj, objName) {
  if (obj && obj.constructor)
    obj._type = obj.constructor.name.toString();
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object')) {
      const propPath = objName + '.' + prop;
      populateType(obj[prop], propPath);
    }
  }
}

/**
 * Populates `_text` property where it can from sourceFile
 * @param {any} obj object to populate text
 * @param {ts.SourceFile} sourceFile sourceFile used to get text
 * @param {string} objName used to output properties path
 */
function populateText(obj, sourceFile, objName) {
  if (obj) {
    if (obj.text) {
      obj._text = obj.text;
    } else if (obj.getText)
      obj._text = obj.getText(sourceFile);
  }
  
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object')) {
      const propPath = objName + '.' + prop;
      populateText(obj[prop], sourceFile, propPath);
    }
  }
}

/**
 * Converts object `Map` properties to plain object, because `Map` not serializing
 * @param {any} obj object to process
 */
function convertMapToArray(obj) {
  for (var prop in obj) {
    if (obj.hasOwnProperty(prop) && obj[prop] && (typeof obj[prop] === 'object')) {
      if (obj[prop] instanceof Map) {
        obj[prop] = Object.fromEntries(obj[prop].entries());
      }
      if (obj[prop] instanceof Set) {
        console.log('Set!');
      }
      convertMapToArray(obj[prop]);
    }
  }
}

module.exports = {
  convertMapToArray,
  populateText,
  populateType,
  removeRemoveKnownCyclicProps
};