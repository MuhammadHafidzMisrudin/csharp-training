array = [1,2,3,4,5,6,[7,8,9,[1,2,3,4,5]],10,11,12,[13,14,15,16],17,18,[19],[20]]

function flatten(arr) {
    return [].concat(...arr);
}

function deepFlattenNestedArray(arr) {
    return flatten(arr.map(x => Array.isArray(x) ? deepFlattenNestedArray(x) : x));
}

console.log("result 1: ", [].concat(...array));
console.log();
console.log("result 2: ", deepFlattenNestedArray(array));