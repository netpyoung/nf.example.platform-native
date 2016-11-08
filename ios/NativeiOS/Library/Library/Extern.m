#import<LibraryExtern.h>
#import<Library/Library-Swift.h>


extern void do_test_static_func() {
    [Library doTestStaticFunc];
}

extern void do_test_instance_func() {
    [[Library instance] doTestInstanceFunc];
}

extern void do_test_callback(Callback callback) {
    // watchout this changed method name
    [[Library instance] doTestCallbackWithCallback:callback];
}
