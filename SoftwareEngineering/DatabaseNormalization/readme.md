
# The Normal Forms

## First Normal Form (1NF)
1. Data cannot be broken down further. (atomic)
2. Columns have no repeating/similar data
3. Each row is unique
4. Each field has a unique name

## Second Normal Form (2NF)
1. should already  be in the 1NF
2. Non-key attributes are functional dependent on primary key

## Third Normal Form (3NF)
1. Should be in 2NF
2. No transitive dependencies
    - A functional dependency between two or more non-key attributes.
    - If..
        - x -> y   (x determines y)
        - y -> z (y determines z)
    - then:
        - x -> z (x should determine z)
    - And
        - y -/> x  (y should not determine x)

## Boyce-Codd Normal Form (BCNF / 4NF)
1. Should be in 3NF
2. No trivial dependencies
    1. (hint, foreign keys)

## Fifth Normal Form (5NF)
1. Should be in 4NF
2. The values of multivalued dependencies are related


## Benefits of Normalization
1. Less redundancy
2. More coherent data
3. simpler verification code
4. Easy update and create
5. Optimal disk space use
## Resources and References
1. [Database Normalization in Under 10 minutes](https://www.youtube.com/watch?v=v3N5PlbUHTs)
