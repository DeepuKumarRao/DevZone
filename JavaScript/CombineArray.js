arr1 = [1, 2, 3];
arr2 = [4, 5, 6];

// Combine arrays using spread operator
arr3 = [...arr1, ...arr2];
// Combine arrays using concat method
arr4 = arr1.concat(arr2);
// Combine arrays using flat method
arr5 = [arr1, arr2].flat();


console.log(arr3);
console.log(arr4);
console.log(arr5);
