# RSA_Base58_Block
RSA block encryption implementation in C# without using the RSACryptoServiceProvider class.

![main interface](https://raw.githubusercontent.com/tabarra/RSA_Base58_Block/master/screenshots/main.png)
  
The objective of this project was to gain experience in the implementation of a trapdoor permutation cryptography, in this case RSA, and that's why I decided to not use any library or API except .NET's BigInteger and [adamcaudill/Base58Check](https://github.com/adamcaudill/Base58Check).  
  
  
## Features  
 - Compatible with large primes (like 2048+ bits) 
 - Multi-threaded random prime number generator
 - Miller-Rabin probabilistic prime number checker implementation as described in [NIST FIPS 186-4 (C.3.2)](http://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.186-4.pdf#page=82)
 - Four-byte padding on each block to guarantee that encoding the same message twice won't generate the same result
 - Base58 encoding of each block, split by an underscore.
 - Status bar to see how much time each operation takes
 - UTF8 compatible
  
## Notes & Disclaimer  
The intention of this project was never to make something good enough to be used in real life applications. Implementing cryptographic functions by yourself is almost never a good idea, and RSA is a great example of one cryptography very easy to screw up and end with a vulnerable code.  
  
If you want to dive deeper in this awesome algorithm, I suggest trying to implement PEM/DER/ASN.1 key parsing, [Chinese Remainder Theorem](https://en.wikipedia.org/wiki/Chinese_remainder_theorem), increasing it's compatibility with [PKCS1 2v2](https://tools.ietf.org/html/rfc8017), reading Dan Boneh's [Twenty Years of Attacks on the RSA Cryptosystem](https://crypto.stanford.edu/~dabo/papers/RSA-survey.pdf) paper or any of his lectures on the subject. You may also want to check [LINKS.md](https://github.com/tabarra/RSA_Base58_Block/blob/master/LINKS.md), where I saved many pages that helped me to understand RSA.

**PS.: This was also my first C# project, so don't expect any part of it to be optimal.**
