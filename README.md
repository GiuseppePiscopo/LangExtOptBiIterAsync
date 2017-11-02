# LangExtOptBiIterAsync
Sample solution showing issue with Language-Ext package and its `Task<Option<>>.BiIterAsync()` method.
See [issue ???](https://github.com/louthy/language-ext/issues/???) on project [home](https://github.com/louthy/language-ext/).

## Steps

1. Restore packages
1. Run from Visual Studio or command line
1. Press a key to actually start processing

See generated console output. It should show:

```
Do Action None
```

instead it actually shows:

```
Do Action Some: '<null>'
```
