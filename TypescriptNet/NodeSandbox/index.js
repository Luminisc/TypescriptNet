const fs = require('fs');
const getSourceFiles = require('./getSourceFiles.js');

const testFileNames = [
  './ts_example/timeSpan.ts',
  './ts_example/downloadSettings.ts',
  './ts_example/mappingSettings.ts',
  './ts_example/taskMapping.ts',
  './ts_example/taskStatus.ts',
  './ts_example/uploadTask.ts',
];
const output = getSourceFiles(testFileNames);
fs.writeFileSync('output.json', JSON.stringify(output, null, 2));