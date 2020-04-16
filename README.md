# WinFLIF

![](https://img.shields.io/github/release/Zaczero/WinFLIF.svg)
![](https://img.shields.io/github/license/Zaczero/WinFLIF.svg)

WinFLIF is a simple FLIF image converter tool for Windows.  
You can easily select and convert files without using command prompt.

---

**FLIF development has stopped since FLIF is superceded by FUIF and then again by JPEG XL (https://jpeg.org/jpegxl/index.html), which is based on a combination of Pik and FUIF. A royalty-free and open source reference implementation of JPEG XL is available on [GitLab](https://gitlab.com/wg1/jpeg-xl).**

---

## 🔗 Download

* https://github.com/Zaczero/WinFLIF/releases/latest

## 🤔 What is FLIF

FLIF is a lossless image format based on MANIAC compression. MANIAC (Meta-Adaptive Near-zero Integer Arithmetic Coding) is a variant of CABAC (context-adaptive binary arithmetic coding), where the contexts are nodes of decision trees which are dynamically learned at encode time.

FLIF outperforms PNG, FFV1, lossless WebP, lossless BPG and lossless JPEG2000 in terms of compression ratio.

Moreover, FLIF supports a form of progressive interlacing (essentially a generalization/improvement of PNG's Adam7) which means that any prefix (e.g. partial download) of a compressed file can be used as a reasonable lossy encoding of the entire image.

[FLIF on GitHub](https://github.com/FLIF-hub/FLIF)

## 🔄 Supported conversions

* from PNG to FLIF
* from FLIF to PNG

This tool will start multiple threads to speed up the conversion process.
