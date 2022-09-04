// import ts from 'typescript';
// import fs from 'fs';
// import * as helpers from './helpers/helpers.js';
const ts = require('typescript');
const fs = require('fs');
const helpers = require('./helpers/helpers.js');

/**
 * Constructing and sanitizing sourceFile
 * @param {string[]} fileName path to file
 * @returns 
 */
function getSourceFile(fileName) {
  const sourceFile = ts.createSourceFile(
    fileName,
    fs.readFileSync(fileName).toString(),
    ts.ScriptTarget.ESNext,
    /*setParentNodes */ false
  );

  helpers.removeRemoveKnownCyclicProps(sourceFile, 'obj');
  //helpers.populateText(sourceFile, sourceFile); // maybe it's not really need as we can get text by using Node pos/end indexes and sourceFile.text
  helpers.populateType(sourceFile);
  helpers.convertMapToArray(sourceFile);
  return sourceFile;
}

/**
 * 
 * @param {string[]} fileNames array of filepaths
 * @returns {ts.SourceFile[]} resulting sourceFiles
 */
module.exports = function(fileNames /* string[] */) {
  // TODO: support folders/glob
  fileNames = fileNames.filter(x => fs.lstatSync(x).isFile());
  return fileNames.map(getSourceFile);
};