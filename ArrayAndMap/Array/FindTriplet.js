function findTriplets(arr) {
    // Sort the array
    arr.sort((a, b) => a - b); 
    let triplets = [];

    for (let i = 0; i < arr.length - 2; i++) {
         // Skip duplicates
        if (i > 0 && arr[i] === arr[i - 1]) continue;

        let left = i + 1, right = arr.length - 1;
        while (left < right) {
            let sum = arr[i] + arr[left] + arr[right];

            if (sum === 0) {
                triplets.push([arr[i], arr[left], arr[right]]);
                // Move both pointers
                left++; right--; 
                // Skip duplicates
                while (arr[left] === arr[left - 1]) left++; 
                // Skip duplicates
                while (arr[right] === arr[right + 1]) right--; 
            } else {
                // Adjust pointers based on sum
                sum < 0 ? left++ : right--; 
            }
        }
    }
    return triplets;
}
console.log(findTriplets([-1, 0, 1, 2, -1, -4]));
