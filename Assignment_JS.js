// 1. Sum all salaries
console.log("\nQuestion 1");
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};
let sum = 0;
for (let key in salaries) {
    sum += salaries[key];
}
console.log("sum = " + sum);

// 2. Multiply all numeric properties
console.log("\nQuestion 2");
function multiplyNumeric(obj) {
    for (let key in obj) {    
        if (typeof obj[key] === 'number') {
            obj[key] *= 2;
        }
    }
}
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};
multiplyNumeric(menu);
console.log(menu);

// 3. Check email ID
console.log("\nQuestion 3");
function checkEmailId(str) {
    const pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    return pattern.test(str);
}
console.log("hyp@gmail.com: " + checkEmailId("hyp@gmail.com")); 
console.log("h.Y.p@gmail.com: " + checkEmailId("h.Y.p@gmail.com"));
console.log("hyp@.com: " + checkEmailId("hyp@.com"));
console.log("hyp.gmail@com: " + checkEmailId("hyp.gmail@com"));

// 4. Truncate string to max length
console.log("\nQuestion 4");
function truncate(str, maxlength) {
    return (str.length > maxlength) ? str.slice(0, maxlength - 1) + '…' : str;
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

// 5. Array operations
console.log("\nQuestion 5");
let styles = ["James", "Brennie"];
console.log("Initial array: " + styles);
styles.push("Robert");
console.log("After appending Robert: " + styles);
styles[Math.floor(styles.length / 2)] = "Calvin";
console.log("After replacing the middle value by Calvin: " + styles);
styles.shift();
console.log("After removing the first value: " + styles);
styles.unshift("Rose", "Regal");
console.log("After prepending Rose and Regal: " + styles);
