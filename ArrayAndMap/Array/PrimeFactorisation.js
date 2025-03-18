function primeFactorization(n) {
    let factors = [];
    // Divide n by 2 until it is odd
    while (n % 2 === 0) {
        factors.push(2);
        n = Math.floor(n / 2);
    }
    // Check for odd factors from 3 to sqrt(n)
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = Math.floor(n / i);
        }
    }
    // If n is still a prime number and greater than 2
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

let num = 120;
let primeFactors = primeFactorization(num);

console.log(`Prime factors of ${num}:`, primeFactors);
