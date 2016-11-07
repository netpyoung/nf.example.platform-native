//
//  ViewController.swift
//  app
//
//  Created by pyoung on 2016. 11. 8..
//  Copyright © 2016년 pyoung. All rights reserved.
//

import UIKit
import Library

class ViewController: UIViewController {

    @IBOutlet weak var button: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    @IBAction func onClickButton(_ sender: UIButton) {
        Library.doTestStaticFunc();
        Library.instance.doTestInstanceFunc();
        Library.instance.doTestCallback(callback: {(msg: UnsafePointer<CChar>) in
            print(String(cString: msg))
        })
    }
}

