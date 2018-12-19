# Digital-Signature
Information theory, lab #4
The program signs and checks the file for validity of the sender(only for text files). The file is digitally signed by obtaining a hash of the file using the SHA1 hashing algorithm and encrypting this hash with the RSA algorithm. To sign a file, open the signed file, enter P and Q (prime numbers) and the private key (the key must be reciprocal with the Euler function ((P - 1) * (Q - 1)), select "subscribe" and click "run". To open a signature, enter the public key n, e. To check the signature for validity, you need to open the signed file and select "check" and click "run". Press when entering p and q "Enter" to output the Euler function from p and q.