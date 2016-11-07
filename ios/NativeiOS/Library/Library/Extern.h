#ifndef Extern_h
#define Extern_h

typedef void (*Callback)(const char *);

extern void do_test_static_func();
extern void do_test_instance_func();
extern void do_test_callback(Callback callback);

#endif /* Extern_h */
