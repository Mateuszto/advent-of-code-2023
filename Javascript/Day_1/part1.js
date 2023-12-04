const fs = require('fs');

const input = fs.readFileSync(`${__dirname}/input.txt`, { encoding: 'utf-8' });

let sum = 0;

for (const line of input.split('\n')) {
    let firstNum, lastNum;
    line.split('').forEach(i => {
        if(!isNaN(Number(i))) {
            if(!firstNum) firstNum = i;
            lastNum = i;
        }
    })
    const res = Number(`${firstNum}${lastNum}`);
    sum += res;
}

console.log(sum); // Should be 54605