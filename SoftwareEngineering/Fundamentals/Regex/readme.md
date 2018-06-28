# Regex

### Examples
1. Character matching:
```
pattern:  22
test string: 222
result: '22'2
```
2. Character classes - matches individual characters within square brackets
```
[aeiou]
abcdefghijklmnopqrstuvwxyz
```

3. match a range of characters `[a-z]`
4. match a range of characters, upper or lower `[a-zA-Z]`
5. match a range of characters, upper or lower `[a-zA-Z1-9]`
6. negate matches `[^a-z]`  matches anything not lowercase
    1. A carat outside has a different meaning. means anchor `^[^a-z]`
7. matching a special character:
    1. two ways (goal: matches, a through z, and a dash):
        1.  escape with backslash `[\-a-z]`
        2. dash at end: `[a-z-]`
8. match characters @ and ^: `[@^]`
    1. reminder, negation: `[^@^]`
