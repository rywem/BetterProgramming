# Regex

Content in this workspace is based upon the course:
[Regex Academy - an introduction to text parsing sorcery](https://www.udemy.com/regex-academy-an-introduction-to-text-parsing-sorcery/learn/v4/content)

### Examples - Matching
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
    - A carat outside has a different meaning. means anchor `^[^a-z]`
7. matching a special character:
    1. two ways (goal: matches, a through z, and a dash):
        1.  escape with backslash `[\-a-z]`
        2. dash at end: `[a-z-]`
8. match characters @ and ^: `[@^]`
    - reminder, negation: `[^@^]`
9. match via ascii table: `[\ -~]`   
    - matches by ascii table position.
10. Alteration: `[cat|dog]  cat dog fish`
    - first tries to match left, then right if it fails
11. metacharacters
    - .  (period) - "anything except new lines"
    - \\w - get all characters (backslash w, `[a-zA-Z0-9]`)
    - \\W - (backslash CAPITAL W for negation, `[^a-zA-Z0-9]`)
    - \\d - get all digits `[0-9]`
    - \\D - negation of all digits `[^0-9]`
    - \\t - tabs
    - \\n - new lines (line breaks)
    - \\s - any type of space (new line, tab, space)
    - \\S - anything not a space, (eg all characters)
    - \\ -  (backslash space) finds spaces
    - \\[, \\] - match actual brackets
12. quantifiers
    1. * - 0 or more times
    2. + - 1 or more times
    ```
    [a-z]+
    hello how are you?
    ```
    3. greedy - consume as much as possible.
        - ? - use question mark to make things non greedy
        - example: creating regex that matches start and end tag, and everything in between:
            - `<p>paragraph 1</p><p>paragraph 2</p><p>paragraph 3</p>`
                - `<p>.+<\/p>` (this is correct) - matches first <p> all the way to the last </p>
                - `<p>.+?<\/p>` (this is incorrect) - matches first <p> to the first occurrence of </p>


### Resources
1. [regex101](https://regex101.com/)
2. Udemy course [Regex Academy - an introduction to text parsing sorcery](https://www.udemy.com/regex-academy-an-introduction-to-text-parsing-sorcery/learn/v4/content)
