prefix=@CMAKE_INSTALL_PREFIX@
exec_prefix=@CMAKE_INSTALL_PREFIX@
libdir=@CMAKE_INSTALL_FULL_LIBDIR@
includedir=@CMAKE_INSTALL_FULL_INCLUDEDIR@/protobuf-3.4.0

Name: Protocol Buffers
Description: Google's Data Interchange Format
Version: @protobuf_VERSION@
Libs: -L${libdir} ${libdir}/libprotobuf.so.@protobuf_SOVERSION@ @CMAKE_THREAD_LIBS_INIT@
Cflags: -I${includedir} @CMAKE_THREAD_LIBS_INIT@
Conflicts: protobuf-lite
