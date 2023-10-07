# PutridParrot.IO

[![Build PutridParrot.IO](https://github.com/putridparrot/PutridParrot.IO/actions/workflows/build.yml/badge.svg)](https://github.com/putridparrot/PutridParrot.IO/actions/workflows/build.yml)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/putridparrot/PutridParrot.IO/blob/master/LICENSE.md)
[![GitHub Releases](https://img.shields.io/github/release/putridparrot/PutridParrot.IO.svg)](https://github.com/putridparrot/PutridParrot.IO/releases)
[![GitHub Issues](https://img.shields.io/github/issues/putridparrot/PutridParrot.IO.svg)](https://github.com/putridparrot/PutridParrot.IO/issues)

Various bit of IO code. 

For example, interfaces to replace the static class Path, Directory and File to enable easier mocking these for use within tests.

## IDirectory, IPath and IFile

When we're developing code to work with the file system, directories etc. we tend to use the static classes Directory, Path and File. The big problem with these is testability. If I want to test code that relies on these, I need to set-up the directory/files structure on my storage to look exactly as required. This is not the end of the world, but it just makes for a lesser unit testing experience. 

IDirectory, IPath and IFile as the names suggests are interfaces for such functionality, then we have implementations which simply call the static classes, but now our code can work with the interfaces and the implementations could be mock based or even defining our own file system, in memory or elsewhere.

Directory, Path and File (within the PutridParrot.IO namespace) simply call directly onto the System.IO Directory, Path and File. Extension methods have been added as well to include further functionality.

_Note: It may seem counterintuitive that we also use the implementations via a singleton, this is just for convenience and allows us to return the interfaces which we can obviously mock (or whatever) easily._

Ironically I do not have unit tests for these classes as, that would mean I end up creating files and folders for the default implementations (which is pretty much what these interfaces and classes are trying to get away from).

## IFileSystem

Continuing with the problem of System.IO Directory, Path and File in terms of testing but also in terms of extending with further functionality is that ultimately we may need two or all of these classes to be useful, an example is EnumerateFiles which is on the Directory class but what if I want to get files with creation dates between two dates, then I need the method to take an IDirectory and an IFile which is fine, but not as good as just using one interface/implementation. The IFileSystem is basically a composite of IDirectory, IPath and IFile but allows us to add extension methods etc. which can use each of those interfaces.

This is primarily of use in situations where we want to extend file system type functionality and need access to more than one of the IDirectory, IPath and/or IFile interfaces.
