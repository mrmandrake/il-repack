using System.Runtime.InteropServices;

namespace ILRepacking.AnyOS.Unix
{
    internal static class Syscall
    {
#pragma warning disable IDE1006 // Naming Styles
        [DllImport("libc", SetLastError = true)]
        public static extern int chmod(string pathname, uint mode);

        [DllImport("libc", SetLastError = true)]
        public static extern int stat(string pathname, out Stat stat);
#pragma warning restore IDE1006 // Naming Styles

        // http://man7.org/linux/man-pages/man2/fstat.2.htm        
        [StructLayout(LayoutKind.Sequential)]
        public struct Stat
        {
            /// <summary>
            /// st_dev - ID of device containing file
            /// </summary>
            public uint DeviceID; 
            /// <summary>
            /// st_ino - Inode number 
            /// </summary>
            public uint InodeNumber; 
            /// <summary>
            /// st_mode - File type and mode
            /// </summary>
            public uint Mode; 
            /// <summary>
            /// st_nlink - Number of hard links
            /// </summary>
            public uint HardLinks; 
            /// <summary>
            /// st_uid - User ID of owner
            /// </summary>
            public uint UserID; 
            /// <summary>
            /// st_gid - Group ID of owner
            /// </summary>
            public uint GroupID; 
            /// <summary>
            /// st_rdev - Device ID (if special file)
            /// </summary>
            public uint SpecialDeviceID; 
            /// <summary>
            /// st_size - Total size, in bytes
            /// </summary>
            public ulong Size; 
            /// <summary>
            /// st_blksize - Block size for filesystem I/O
            /// </summary>
            public ulong BlockSize;
            /// <summary>
            /// st_blocks - Number of 512B blocks allocated
            /// </summary>
            public uint Blocks; 
            /// <summary>
            /// st_atim - Time of last access in nanoseconds
            /// </summary>
            public long TimeLastAccess; 
            /// <summary>
            /// st_mtim - Time of last modification in nanoseconds
            /// </summary>
            public long TimeLastModification;
            /// <summary>
            /// st_ctim - Time of last status change in nanoseconds
            /// </summary>
            public long TimeLastStatusChange; 
        }

    }
}