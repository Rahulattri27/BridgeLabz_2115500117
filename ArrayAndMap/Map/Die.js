function rollDie() {
    return Math.floor(Math.random() * 6) + 1; 
}
function simulateDiceRolls() {
    let dieResults = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
    let maxRolls = 10;
    let maxNumber, minNumber;

    while (true) {
        let roll = rollDie();
        dieResults[roll]++;
        if (dieResults[roll] === maxRolls) {
            break;
        }
    }
    // Find the most and least frequent numbers
    maxNumber = Object.keys(dieResults).reduce((a, b) => dieResults[a] > dieResults[b] ? a : b);
    minNumber = Object.keys(dieResults).reduce((a, b) => dieResults[a] < dieResults[b] ? a : b);

    console.log("Final Die Counts:", dieResults);
    console.log(`Number that reached 10 times: ${maxNumber}`);
    console.log(`Number that appeared least: ${minNumber}`);
}

simulateDiceRolls();
