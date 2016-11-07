import Foundation

@objc
public class Library : NSObject {
    public typealias Callback = @convention(c) (UnsafePointer<CChar>) -> Void
    
    // singletone
    public static let instance = Library()
    
    private override init() {
        super.init();
    }
    
    // static func
    public static func doTestStaticFunc() {
        print("[testStatic] called ")
    }
    
    // instance func
    public func doTestInstanceFunc() {
        print("[doTestInstanceFunc] called")
    }
    
    public func doTestCallback(callback: Callback) {
        print("[doTestCallback] before pass")
        callback("passed by doTestCallback")
        print("[doTestCallback] after pass")
    }
}
