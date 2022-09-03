// console.log('Hello world');
import { readFileSync } from "fs";
import ts from "typescript";

const fileNames = ['./ts_example/timeSpan.ts','./ts_example/downloadSettings.ts'];
const output = fileNames.map(fileName => {
  // Parse a file
  const sourceFile = ts.createSourceFile(
    fileName,
    readFileSync(fileName).toString(),
    ts.ScriptTarget.ESNext,
    /*setParentNodes */ true
  );
  // console.log(sourceFile.fileName);
  return sourceFile;
});

export default function (callback: any, filePath: string) {
  callback(null, filePath);
};