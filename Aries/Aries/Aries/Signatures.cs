﻿
namespace Aries
{
    sealed class Signatures
    {
        //Signatures used in the Fake File Signature option
        public static byte[] PeCompact2xx = { 184, 0, 0, 0, 0, 80, 100, 255, 53,
                                                0, 0, 0, 0, 100, 137, 37, 0, 0, 0, 0, 
                                                51, 192, 137, 8, 80, 69, 67, 111, 109,
                                                112, 97, 99, 116, 50, 0};

        public static byte[] Armadillo440 = { 49, 46, 49, 46, 52, 0, 0, 0, 194, 224, 148, 
                                                190, 147, 252, 222, 198, 182, 36, 131, 247, 
                                                210, 164, 146, 119, 64, 39, 207, 235, 216, 
                                                111, 80, 180, 181, 41, 36, 250, 69, 8, 4, 
                                                82, 213, 27, 210, 140, 138, 30, 110, 255, 
                                                140, 95, 66, 137, 241, 131, 177, 39, 197, 
                                                105, 87, 252, 85, 10, 221, 68, 190, 42, 2, 
                                                151, 107, 101, 21, 170, 49, 233, 40, 125, 
                                                73, 27, 223, 181, 93, 8, 168, 186, 168 };

        public static byte[] Themida = { 139, 197, 139, 212, 96, 232, 0, 0, 0, 0, 93, 129, 
                                           237, 0, 0, 53, 9, 137, 149, 0, 0, 53, 9, 137, 181, 
                                           0, 0, 53, 9, 137, 133, 0, 0, 53, 9, 131, 189, 0, 0, 
                                           53, 9, 0, 116, 12, 139, 232, 139, 226, 184, 1, 0, 0, 
                                           0, 194, 12, 0, 139, 68, 36, 36, 137, 133, 0, 0, 53, 
                                           9, 106, 69, 232, 163, 0, 0, 0, 104, 154, 116, 131, 7, 
                                           232, 223, 0, 0, 0, 104, 37 };

        public static byte[] ASProtect = { 144, 96, 232, 3, 0, 0, 0, 233, 235, 4, 93, 69, 85, 195, 
                                             232, 1, 0, 0, 0, 235, 93, 187, 237, 255, 255, 255, 3, 
                                             221, 129, 235, 0, 0, 0, 0, 128, 125, 77, 1, 117, 12, 
                                             139, 116, 36, 40, 131, 254, 1, 137, 93, 78, 117, 49, 
                                             141, 69, 83, 80, 83, 255, 181, 213, 9, 0, 0, 141, 69, 
                                             53, 80, 233, 130, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                                             0, 0, 0, 0 };

        public static byte[] UPX = { 1, 219, 0, 7, 139, 30, 131, 238, 252, 17, 219, 138, 7, 0, 235, 
                                       184, 1, 0, 0, 0, 1, 219, 0, 7, 139, 30, 131, 238, 252, 17, 
                                       219, 17, 192, 1, 219, 115, 239 };

        public static byte[] NSPack = { 86, 105, 114, 116, 117, 97, 108, 80, 114, 111, 116, 101, 99, 
                                          116, 0, 0, 187, 1, 71, 101, 116, 83, 121, 115, 116, 101, 109, 
                                          73, 110, 102, 111, 0, 75, 69, 82, 78, 69, 76, 51, 50, 46, 100, 
                                          108, 108, 0, 0, 94, 0, 95, 67, 111, 114, 0, 0, 0, 77, 97, 105, 
                                          110, 0, 109, 115, 99, 111, 114, 101, 101, 46, 100, 108, 108 };
    }
}