## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
|Input 1, output all #s up to input | "1" | 1
|Input 2, output all #s up to input | "2" | 1, 2
|Input 3, replaces 3 with "ping" | "3" |"1, 2, ping"
|Input 5, replaces 5 with "pong" | "5" |"1, 2, ping, 4, pong"
|Input 15, replaces 15 with "ping-pong" | "15" |"....13, ping, ping-pong"
|Input letters, prompt "must be #"|"a" |"Please enter numbers"
|Input negative numbers, prompt "must be positive #"| -3 | "Please enter positive #"
