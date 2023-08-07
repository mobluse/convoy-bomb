# Convoy Bomb
Convoy Bomb is a game originally for ZX81 in [ZX FORTH by Artic](http://www.zx81stuff.org.uk/zx81/tape/ZXForth),
but now in [GForth](https://gforth.org/) using XTerm (or similar) with Unicode. You also need semigraphics.
How to install and run in Linux:

    git clone https://github.com/mobluse/semigraphics
    git clone https://github.com/mobluse/convoy-bomb
    cd convoy-bomb
    gforth convoy-bomb.g.fs
    convoy-bomb
    show-cur ( if you terminate using Ctrl+C )

Convoy Bomb is in Swedish; both instructions and code. Use without Caps Lock or Shift.
B drops a bomb. N/L means New Line i.e. Enter AKA Return. ZX81 does not have ÅÄÖ, but I used 0 for Ö on ZX81,
but in the GForth version I now use ÅÄÖ in the text.
