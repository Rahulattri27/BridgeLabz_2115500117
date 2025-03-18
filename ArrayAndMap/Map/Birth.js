function generateBirthdays() {
    let birthMonthMap = {};
    for (let i = 1; i <= 12; i++) {
        birthMonthMap[i] = [];
    }
    // Generate 50 random birth months for individuals
    for (let i = 1; i <= 50; i++) {
        let month = Math.floor(Math.random() * 12) + 1; 
        let year = Math.random() < 0.5 ? 1992 : 1993;  
        birthMonthMap[month].push(`Person${i} (Year: ${year})`);
    }
    //Display output
    console.log("Individuals grouped by birth month:");
    for (let month in birthMonthMap) {
        if (birthMonthMap[month].length > 0) {
            console.log(`Month ${month}:`, birthMonthMap[month]);
        }
    }
}

generateBirthdays();
