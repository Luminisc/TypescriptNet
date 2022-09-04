const getSourceFiles = require('./getSourceFiles.js');

module.exports = function (callback, ...fileNames) {
  callback(null, getSourceFiles(fileNames));
};