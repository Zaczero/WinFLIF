# WinFLIF

[![GitHub issues](https://img.shields.io/github/issues/Zaczero/WinFLIF.svg)](https://github.com/Zaczero/WinFLIF/issues) [![GitHub stars](https://img.shields.io/github/stars/Zaczero/WinFLIF.svg)](https://github.com/Zaczero/WinFLIF/stargazers) [![GitHub license](https://img.shields.io/github/license/Zaczero/WinFLIF.svg)](https://github.com/Zaczero/WinFLIF/blob/master/LICENSE)

WinFLIF is a simple FLIF image converter tool for Windows.  
You can easily select and convert files without using command prompt.

## Download

* <https://github.com/Zaczero/WinFLIF/releases>

## What is FLIF

FLIF is a lossless image format based on MANIAC compression. MANIAC (Meta-Adaptive Near-zero Integer Arithmetic Coding) is a variant of CABAC (context-adaptive binary arithmetic coding), where the contexts are nodes of decision trees which are dynamically learned at encode time.

FLIF outperforms PNG, FFV1, lossless WebP, lossless BPG and lossless JPEG2000 in terms of compression ratio.

Moreover, FLIF supports a form of progressive interlacing (essentially a generalization/improvement of PNG's Adam7) which means that any prefix (e.g. partial download) of a compressed file can be used as a reasonable lossy encoding of the entire image.

[FLIF on GitHub](https://github.com/FLIF-hub/FLIF)

## Supported conversions

* from PNG to FLIF
* from FLIF to PNG

This tool will start multiple threads to speed up the conversion process.
