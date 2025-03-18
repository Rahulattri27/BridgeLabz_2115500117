function findRepeatedDigits() {
    let repeatedNumbers = [];

    for (let i = 10; i <= 99; i++) { 
        let firstDigit = Math.floor(i / 10); 
        let secondDigit = i % 10; 

        if (firstDigit === secondDigit) {
            repeatedNumbers.push(i);
        }
    }

    return repeatedNumbers;
}

console.log("Numbers with repeated digits:", findRepeatedDigits());
