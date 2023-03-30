
// Tested at: https://onecompiler.com/javascript/3z47r8v79

console.log(markDownParser("======= simple markDownParser function execution starts ========="));
console.log(markDownParser("# Header"));
console.log(markDownParser("## Header"));
console.log(markDownParser("###### Header"));
console.log(markDownParser("####### Header"));
console.log(markDownParser("Header"));
console.log(markDownParser("======= simple markDownParser function execution ends ========="));

function markDownParser(markdown) {

  if (/^ *# +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h1>' + content + '</h1>';
  } else if (/^ *## +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h2>' + content + '</h2>';
  } else if (/^ *### +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h3>' + content + '</h3>';
  } else if (/^ *#### +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h4>' + content + '</h4>';
  } else if (/^ *##### +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h5>' + content + '</h5>';
  } else if (/^ *###### +.*$/.test(markdown)) {
    var content = getSubstringMarkDown(markdown);
    return '<h6>' + content + '</h6>';
  } else {
    return markdown;
  }
}

function getSubstringMarkDown(markdown) {
  const regEx = RegExp(/^ *#+ +/, 'g');
  var arrMarkDown = regEx.exec(markdown);

  if (arrMarkDown !== null) {
    var substring = markdown.substring(regEx.lastIndex);
    return substring.trim();
  } else {
    return markdown;
  }
}


