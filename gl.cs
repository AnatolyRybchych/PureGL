
using System.Reflection;
using System.Runtime.InteropServices;

namespace GL;

using  GLenum = System.UInt32;
using  GLboolean = System.Byte;
using  GLbitfield = System.UInt32;
using  GLvoid = System.IntPtr;
using  GLbyte = System.SByte;
using  GLshort = System.Int16;
using  GLint = System.Int32;
using  GLubyte = System.Byte;
using  GLushort = System.UInt16;
using  GLuint = System.UInt32;
using  GLsizei = System.Int32;
using  GLfloat = System.Single;
using  GLclampf = System.Single;
using  GLdouble = System.Double;
using  GLclampd = System.Double;
using  __u_char = System.Byte;
using  __u_short = System.UInt16;
using  __u_int = System.UInt32;
using  __u_long = System.UInt64;
using  __int8_t = System.SByte;
using  __uint8_t = System.Byte;
using  __int16_t = System.Int16;
using  __uint16_t = System.UInt16;
using  __int32_t = System.Int32;
using  __uint32_t = System.UInt32;
using  __int64_t = System.Int64;
using  __uint64_t = System.UInt64;
using  __int_least8_t = System.SByte;
using  __uint_least8_t = System.SByte;
using  __int_least16_t = System.Int32;
using  __uint_least16_t = System.Int32;
using  __int_least32_t = System.Int32;
using  __uint_least32_t = System.Int32;
using  __int_least64_t = System.Int32;
using  __uint_least64_t = System.Int32;
using  __quad_t = System.Int64;
using  __u_quad_t = System.UInt64;
using  __intmax_t = System.Int64;
using  __uintmax_t = System.UInt64;
using  __dev_t = System.UInt64;
using  __uid_t = System.UInt32;
using  __gid_t = System.UInt32;
using  __ino_t = System.UInt64;
using  __ino64_t = System.UInt64;
using  __mode_t = System.UInt32;
using  __nlink_t = System.UInt64;
using  __off_t = System.Int64;
using  __off64_t = System.Int64;
using  __pid_t = System.Int32;
using  __clock_t = System.Int64;
using  __rlim_t = System.UInt64;
using  __rlim64_t = System.UInt64;
using  __id_t = System.UInt32;
using  __time_t = System.Int64;
using  __useconds_t = System.UInt32;
using  __suseconds_t = System.Int64;
using  __daddr_t = System.Int32;
using  __key_t = System.Int32;
using  __clockid_t = System.Int32;
using  __timer_t = System.IntPtr /*void*/;
using  __blksize_t = System.Int64;
using  __blkcnt_t = System.Int64;
using  __blkcnt64_t = System.Int64;
using  __fsblkcnt_t = System.UInt64;
using  __fsblkcnt64_t = System.UInt64;
using  __fsfilcnt_t = System.UInt64;
using  __fsfilcnt64_t = System.UInt64;
using  __fsword_t = System.Int64;
using  __ssize_t = System.Int64;
using  __syscall_slong_t = System.Int64;
using  __syscall_ulong_t = System.UInt64;
using  __loff_t = System.Int32;
using  __caddr_t = System.IntPtr /*System.SByte*/;
using  __intptr_t = System.Int64;
using  __socklen_t = System.UInt32;
using  __sig_atomic_t = System.Int32;
using  int8_t = System.SByte;
using  int16_t = System.Int32;
using  int32_t = System.Int32;
using  int64_t = System.Int32;
using  uint8_t = System.SByte;
using  uint16_t = System.Int32;
using  uint32_t = System.Int32;
using  uint64_t = System.Int32;
using  int_least8_t = System.SByte;
using  int_least16_t = System.Int32;
using  int_least32_t = System.Int32;
using  int_least64_t = System.Int32;
using  uint_least8_t = System.SByte;
using  uint_least16_t = System.Int32;
using  uint_least32_t = System.Int32;
using  uint_least64_t = System.Int32;
using  int_fast8_t = System.SByte;
using  int_fast16_t = System.Int64;
using  int_fast32_t = System.Int64;
using  int_fast64_t = System.Int64;
using  uint_fast8_t = System.Byte;
using  uint_fast16_t = System.UInt64;
using  uint_fast32_t = System.UInt64;
using  uint_fast64_t = System.UInt64;
using  intptr_t = System.Int64;
using  uintptr_t = System.UInt64;
using  intmax_t = System.Int32;
using  uintmax_t = System.Int32;
using  khronos_int32_t = System.Int32;
using  khronos_uint32_t = System.Int32;
using  khronos_int64_t = System.Int32;
using  khronos_uint64_t = System.Int32;
using  khronos_int8_t = System.SByte;
using  khronos_uint8_t = System.Byte;
using  khronos_int16_t = System.Int16;
using  khronos_uint16_t = System.UInt16;
using  khronos_intptr_t = System.Int64;
using  khronos_uintptr_t = System.UInt64;
using  khronos_ssize_t = System.Int64;
using  khronos_usize_t = System.UInt64;
using  khronos_float_t = System.Single;
using  khronos_utime_nanoseconds_t = System.Int32;
using  khronos_stime_nanoseconds_t = System.Int32;
using  GLsizeiptr = System.Int32;
using  GLintptr = System.Int32;
using  GLchar = System.SByte;
using  GLhalf = System.Int32;
using  GLsync = System.IntPtr /*|__GLsync*|*/ ;
using  GLuint64 = System.Int32;
using  GLint64 = System.Int32;
using  GLuint64EXT = System.Int32;
using  GLhalfARB = System.Int32;
using  GLhandleARB = System.UInt32;
using  GLcharARB = System.SByte;
using  GLsizeiptrARB = System.Int32;
using  GLintptrARB = System.Int32;
using  GLfixed = System.Int32;
using  GLint64EXT = System.Int32;
using  GLeglImageOES = System.IntPtr /*void*/;
using  GLeglClientBufferEXT = System.IntPtr /*void*/;
using  GLhalfNV = System.UInt16;
using  GLvdpauSurfaceNV = System.Int32;

public static class GL{
    private static IntPtr Resolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if(libraryName == "GL")
        {
            if(Environment.OSVersion.Platform == PlatformID.Unix)
            {
                return NativeLibrary.Load(LinuxLibrary, assembly, searchPath);
            }
            else if(Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return NativeLibrary.Load(WindowsLibrary, assembly, searchPath);
            }
            else
            {
                throw new PlatformNotSupportedException("Supported only linux and windows yet");
            }
        }
        return IntPtr.Zero;
    }

    static GL()
    {
        NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), Resolver);
    }

    public const string LinuxLibrary = "libGL.so.1";
    public const string WindowsLibrary = "opengl32.dll";

    public const string Lib = "GL";
    
    public unsafe struct __fsid_t 
    {
        public unsafe fixed System.Int32 __val[2];
    }
    public const string GLAPI = "default";
    public const long WIN32_LEAN_AND_MEAN = 1;
    public const long GL_VERSION_1_1 = 1;
    public const long GL_VERSION_1_2 = 1;
    public const long GL_VERSION_1_3 = 1;
    public const long GL_ARB_imaging = 1;
    public const long GL_FALSE = 0;
    public const long GL_TRUE = 1;
    public const long GL_BYTE = 0x1400;
    public const long GL_UNSIGNED_BYTE = 0x1401;
    public const long GL_SHORT = 0x1402;
    public const long GL_UNSIGNED_SHORT = 0x1403;
    public const long GL_INT = 0x1404;
    public const long GL_UNSIGNED_INT = 0x1405;
    public const long GL_FLOAT = 0x1406;
    public const long GL_2_BYTES = 0x1407;
    public const long GL_3_BYTES = 0x1408;
    public const long GL_4_BYTES = 0x1409;
    public const long GL_DOUBLE = 0x140A;
    public const long GL_POINTS = 0x0000;
    public const long GL_LINES = 0x0001;
    public const long GL_LINE_LOOP = 0x0002;
    public const long GL_LINE_STRIP = 0x0003;
    public const long GL_TRIANGLES = 0x0004;
    public const long GL_TRIANGLE_STRIP = 0x0005;
    public const long GL_TRIANGLE_FAN = 0x0006;
    public const long GL_QUADS = 0x0007;
    public const long GL_QUAD_STRIP = 0x0008;
    public const long GL_POLYGON = 0x0009;
    public const long GL_VERTEX_ARRAY = 0x8074;
    public const long GL_NORMAL_ARRAY = 0x8075;
    public const long GL_COLOR_ARRAY = 0x8076;
    public const long GL_INDEX_ARRAY = 0x8077;
    public const long GL_TEXTURE_COORD_ARRAY = 0x8078;
    public const long GL_EDGE_FLAG_ARRAY = 0x8079;
    public const long GL_VERTEX_ARRAY_SIZE = 0x807A;
    public const long GL_VERTEX_ARRAY_TYPE = 0x807B;
    public const long GL_VERTEX_ARRAY_STRIDE = 0x807C;
    public const long GL_NORMAL_ARRAY_TYPE = 0x807E;
    public const long GL_NORMAL_ARRAY_STRIDE = 0x807F;
    public const long GL_COLOR_ARRAY_SIZE = 0x8081;
    public const long GL_COLOR_ARRAY_TYPE = 0x8082;
    public const long GL_COLOR_ARRAY_STRIDE = 0x8083;
    public const long GL_INDEX_ARRAY_TYPE = 0x8085;
    public const long GL_INDEX_ARRAY_STRIDE = 0x8086;
    public const long GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
    public const long GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
    public const long GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
    public const long GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
    public const long GL_VERTEX_ARRAY_POINTER = 0x808E;
    public const long GL_NORMAL_ARRAY_POINTER = 0x808F;
    public const long GL_COLOR_ARRAY_POINTER = 0x8090;
    public const long GL_INDEX_ARRAY_POINTER = 0x8091;
    public const long GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
    public const long GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
    public const long GL_V2F = 0x2A20;
    public const long GL_V3F = 0x2A21;
    public const long GL_C4UB_V2F = 0x2A22;
    public const long GL_C4UB_V3F = 0x2A23;
    public const long GL_C3F_V3F = 0x2A24;
    public const long GL_N3F_V3F = 0x2A25;
    public const long GL_C4F_N3F_V3F = 0x2A26;
    public const long GL_T2F_V3F = 0x2A27;
    public const long GL_T4F_V4F = 0x2A28;
    public const long GL_T2F_C4UB_V3F = 0x2A29;
    public const long GL_T2F_C3F_V3F = 0x2A2A;
    public const long GL_T2F_N3F_V3F = 0x2A2B;
    public const long GL_T2F_C4F_N3F_V3F = 0x2A2C;
    public const long GL_T4F_C4F_N3F_V4F = 0x2A2D;
    public const long GL_MATRIX_MODE = 0x0BA0;
    public const long GL_MODELVIEW = 0x1700;
    public const long GL_PROJECTION = 0x1701;
    public const long GL_TEXTURE = 0x1702;
    public const long GL_POINT_SMOOTH = 0x0B10;
    public const long GL_POINT_SIZE = 0x0B11;
    public const long GL_POINT_SIZE_GRANULARITY = 0x0B13;
    public const long GL_POINT_SIZE_RANGE = 0x0B12;
    public const long GL_LINE_SMOOTH = 0x0B20;
    public const long GL_LINE_STIPPLE = 0x0B24;
    public const long GL_LINE_STIPPLE_PATTERN = 0x0B25;
    public const long GL_LINE_STIPPLE_REPEAT = 0x0B26;
    public const long GL_LINE_WIDTH = 0x0B21;
    public const long GL_LINE_WIDTH_GRANULARITY = 0x0B23;
    public const long GL_LINE_WIDTH_RANGE = 0x0B22;
    public const long GL_POINT = 0x1B00;
    public const long GL_LINE = 0x1B01;
    public const long GL_FILL = 0x1B02;
    public const long GL_CW = 0x0900;
    public const long GL_CCW = 0x0901;
    public const long GL_FRONT = 0x0404;
    public const long GL_BACK = 0x0405;
    public const long GL_POLYGON_MODE = 0x0B40;
    public const long GL_POLYGON_SMOOTH = 0x0B41;
    public const long GL_POLYGON_STIPPLE = 0x0B42;
    public const long GL_EDGE_FLAG = 0x0B43;
    public const long GL_CULL_FACE = 0x0B44;
    public const long GL_CULL_FACE_MODE = 0x0B45;
    public const long GL_FRONT_FACE = 0x0B46;
    public const long GL_POLYGON_OFFSET_FACTOR = 0x8038;
    public const long GL_POLYGON_OFFSET_UNITS = 0x2A00;
    public const long GL_POLYGON_OFFSET_POINT = 0x2A01;
    public const long GL_POLYGON_OFFSET_LINE = 0x2A02;
    public const long GL_POLYGON_OFFSET_FILL = 0x8037;
    public const long GL_COMPILE = 0x1300;
    public const long GL_COMPILE_AND_EXECUTE = 0x1301;
    public const long GL_LIST_BASE = 0x0B32;
    public const long GL_LIST_INDEX = 0x0B33;
    public const long GL_LIST_MODE = 0x0B30;
    public const long GL_NEVER = 0x0200;
    public const long GL_LESS = 0x0201;
    public const long GL_EQUAL = 0x0202;
    public const long GL_LEQUAL = 0x0203;
    public const long GL_GREATER = 0x0204;
    public const long GL_NOTEQUAL = 0x0205;
    public const long GL_GEQUAL = 0x0206;
    public const long GL_ALWAYS = 0x0207;
    public const long GL_DEPTH_TEST = 0x0B71;
    public const long GL_DEPTH_BITS = 0x0D56;
    public const long GL_DEPTH_CLEAR_VALUE = 0x0B73;
    public const long GL_DEPTH_FUNC = 0x0B74;
    public const long GL_DEPTH_RANGE = 0x0B70;
    public const long GL_DEPTH_WRITEMASK = 0x0B72;
    public const long GL_DEPTH_COMPONENT = 0x1902;
    public const long GL_LIGHTING = 0x0B50;
    public const long GL_LIGHT0 = 0x4000;
    public const long GL_LIGHT1 = 0x4001;
    public const long GL_LIGHT2 = 0x4002;
    public const long GL_LIGHT3 = 0x4003;
    public const long GL_LIGHT4 = 0x4004;
    public const long GL_LIGHT5 = 0x4005;
    public const long GL_LIGHT6 = 0x4006;
    public const long GL_LIGHT7 = 0x4007;
    public const long GL_SPOT_EXPONENT = 0x1205;
    public const long GL_SPOT_CUTOFF = 0x1206;
    public const long GL_CONSTANT_ATTENUATION = 0x1207;
    public const long GL_LINEAR_ATTENUATION = 0x1208;
    public const long GL_QUADRATIC_ATTENUATION = 0x1209;
    public const long GL_AMBIENT = 0x1200;
    public const long GL_DIFFUSE = 0x1201;
    public const long GL_SPECULAR = 0x1202;
    public const long GL_SHININESS = 0x1601;
    public const long GL_EMISSION = 0x1600;
    public const long GL_POSITION = 0x1203;
    public const long GL_SPOT_DIRECTION = 0x1204;
    public const long GL_AMBIENT_AND_DIFFUSE = 0x1602;
    public const long GL_COLOR_INDEXES = 0x1603;
    public const long GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
    public const long GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
    public const long GL_LIGHT_MODEL_AMBIENT = 0x0B53;
    public const long GL_FRONT_AND_BACK = 0x0408;
    public const long GL_SHADE_MODEL = 0x0B54;
    public const long GL_FLAT = 0x1D00;
    public const long GL_SMOOTH = 0x1D01;
    public const long GL_COLOR_MATERIAL = 0x0B57;
    public const long GL_COLOR_MATERIAL_FACE = 0x0B55;
    public const long GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
    public const long GL_NORMALIZE = 0x0BA1;
    public const long GL_CLIP_PLANE0 = 0x3000;
    public const long GL_CLIP_PLANE1 = 0x3001;
    public const long GL_CLIP_PLANE2 = 0x3002;
    public const long GL_CLIP_PLANE3 = 0x3003;
    public const long GL_CLIP_PLANE4 = 0x3004;
    public const long GL_CLIP_PLANE5 = 0x3005;
    public const long GL_ACCUM_RED_BITS = 0x0D58;
    public const long GL_ACCUM_GREEN_BITS = 0x0D59;
    public const long GL_ACCUM_BLUE_BITS = 0x0D5A;
    public const long GL_ACCUM_ALPHA_BITS = 0x0D5B;
    public const long GL_ACCUM_CLEAR_VALUE = 0x0B80;
    public const long GL_ACCUM = 0x0100;
    public const long GL_ADD = 0x0104;
    public const long GL_LOAD = 0x0101;
    public const long GL_MULT = 0x0103;
    public const long GL_RETURN = 0x0102;
    public const long GL_ALPHA_TEST = 0x0BC0;
    public const long GL_ALPHA_TEST_REF = 0x0BC2;
    public const long GL_ALPHA_TEST_FUNC = 0x0BC1;
    public const long GL_BLEND = 0x0BE2;
    public const long GL_BLEND_SRC = 0x0BE1;
    public const long GL_BLEND_DST = 0x0BE0;
    public const long GL_ZERO = 0;
    public const long GL_ONE = 1;
    public const long GL_SRC_COLOR = 0x0300;
    public const long GL_ONE_MINUS_SRC_COLOR = 0x0301;
    public const long GL_SRC_ALPHA = 0x0302;
    public const long GL_ONE_MINUS_SRC_ALPHA = 0x0303;
    public const long GL_DST_ALPHA = 0x0304;
    public const long GL_ONE_MINUS_DST_ALPHA = 0x0305;
    public const long GL_DST_COLOR = 0x0306;
    public const long GL_ONE_MINUS_DST_COLOR = 0x0307;
    public const long GL_SRC_ALPHA_SATURATE = 0x0308;
    public const long GL_FEEDBACK = 0x1C01;
    public const long GL_RENDER = 0x1C00;
    public const long GL_SELECT = 0x1C02;
    public const long GL_2D = 0x0600;
    public const long GL_3D = 0x0601;
    public const long GL_3D_COLOR = 0x0602;
    public const long GL_3D_COLOR_TEXTURE = 0x0603;
    public const long GL_4D_COLOR_TEXTURE = 0x0604;
    public const long GL_POINT_TOKEN = 0x0701;
    public const long GL_LINE_TOKEN = 0x0702;
    public const long GL_LINE_RESET_TOKEN = 0x0707;
    public const long GL_POLYGON_TOKEN = 0x0703;
    public const long GL_BITMAP_TOKEN = 0x0704;
    public const long GL_DRAW_PIXEL_TOKEN = 0x0705;
    public const long GL_COPY_PIXEL_TOKEN = 0x0706;
    public const long GL_PASS_THROUGH_TOKEN = 0x0700;
    public const long GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
    public const long GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
    public const long GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
    public const long GL_SELECTION_BUFFER_POINTER = 0x0DF3;
    public const long GL_SELECTION_BUFFER_SIZE = 0x0DF4;
    public const long GL_FOG = 0x0B60;
    public const long GL_FOG_MODE = 0x0B65;
    public const long GL_FOG_DENSITY = 0x0B62;
    public const long GL_FOG_COLOR = 0x0B66;
    public const long GL_FOG_INDEX = 0x0B61;
    public const long GL_FOG_START = 0x0B63;
    public const long GL_FOG_END = 0x0B64;
    public const long GL_LINEAR = 0x2601;
    public const long GL_EXP = 0x0800;
    public const long GL_EXP2 = 0x0801;
    public const long GL_LOGIC_OP = 0x0BF1;
    public const long GL_INDEX_LOGIC_OP = 0x0BF1;
    public const long GL_COLOR_LOGIC_OP = 0x0BF2;
    public const long GL_LOGIC_OP_MODE = 0x0BF0;
    public const long GL_CLEAR = 0x1500;
    public const long GL_SET = 0x150F;
    public const long GL_COPY = 0x1503;
    public const long GL_COPY_INVERTED = 0x150C;
    public const long GL_NOOP = 0x1505;
    public const long GL_INVERT = 0x150A;
    public const long GL_AND = 0x1501;
    public const long GL_NAND = 0x150E;
    public const long GL_OR = 0x1507;
    public const long GL_NOR = 0x1508;
    public const long GL_XOR = 0x1506;
    public const long GL_EQUIV = 0x1509;
    public const long GL_AND_REVERSE = 0x1502;
    public const long GL_AND_INVERTED = 0x1504;
    public const long GL_OR_REVERSE = 0x150B;
    public const long GL_OR_INVERTED = 0x150D;
    public const long GL_STENCIL_BITS = 0x0D57;
    public const long GL_STENCIL_TEST = 0x0B90;
    public const long GL_STENCIL_CLEAR_VALUE = 0x0B91;
    public const long GL_STENCIL_FUNC = 0x0B92;
    public const long GL_STENCIL_VALUE_MASK = 0x0B93;
    public const long GL_STENCIL_FAIL = 0x0B94;
    public const long GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
    public const long GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
    public const long GL_STENCIL_REF = 0x0B97;
    public const long GL_STENCIL_WRITEMASK = 0x0B98;
    public const long GL_STENCIL_INDEX = 0x1901;
    public const long GL_KEEP = 0x1E00;
    public const long GL_REPLACE = 0x1E01;
    public const long GL_INCR = 0x1E02;
    public const long GL_DECR = 0x1E03;
    public const long GL_NONE = 0;
    public const long GL_LEFT = 0x0406;
    public const long GL_RIGHT = 0x0407;
    public const long GL_FRONT_LEFT = 0x0400;
    public const long GL_FRONT_RIGHT = 0x0401;
    public const long GL_BACK_LEFT = 0x0402;
    public const long GL_BACK_RIGHT = 0x0403;
    public const long GL_AUX0 = 0x0409;
    public const long GL_AUX1 = 0x040A;
    public const long GL_AUX2 = 0x040B;
    public const long GL_AUX3 = 0x040C;
    public const long GL_COLOR_INDEX = 0x1900;
    public const long GL_RED = 0x1903;
    public const long GL_GREEN = 0x1904;
    public const long GL_BLUE = 0x1905;
    public const long GL_ALPHA = 0x1906;
    public const long GL_LUMINANCE = 0x1909;
    public const long GL_LUMINANCE_ALPHA = 0x190A;
    public const long GL_ALPHA_BITS = 0x0D55;
    public const long GL_RED_BITS = 0x0D52;
    public const long GL_GREEN_BITS = 0x0D53;
    public const long GL_BLUE_BITS = 0x0D54;
    public const long GL_INDEX_BITS = 0x0D51;
    public const long GL_SUBPIXEL_BITS = 0x0D50;
    public const long GL_AUX_BUFFERS = 0x0C00;
    public const long GL_READ_BUFFER = 0x0C02;
    public const long GL_DRAW_BUFFER = 0x0C01;
    public const long GL_DOUBLEBUFFER = 0x0C32;
    public const long GL_STEREO = 0x0C33;
    public const long GL_BITMAP = 0x1A00;
    public const long GL_COLOR = 0x1800;
    public const long GL_DEPTH = 0x1801;
    public const long GL_STENCIL = 0x1802;
    public const long GL_DITHER = 0x0BD0;
    public const long GL_RGB = 0x1907;
    public const long GL_RGBA = 0x1908;
    public const long GL_MAX_LIST_NESTING = 0x0B31;
    public const long GL_MAX_EVAL_ORDER = 0x0D30;
    public const long GL_MAX_LIGHTS = 0x0D31;
    public const long GL_MAX_CLIP_PLANES = 0x0D32;
    public const long GL_MAX_TEXTURE_SIZE = 0x0D33;
    public const long GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
    public const long GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
    public const long GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
    public const long GL_MAX_NAME_STACK_DEPTH = 0x0D37;
    public const long GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
    public const long GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
    public const long GL_MAX_VIEWPORT_DIMS = 0x0D3A;
    public const long GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
    public const long GL_ATTRIB_STACK_DEPTH = 0x0BB0;
    public const long GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
    public const long GL_COLOR_CLEAR_VALUE = 0x0C22;
    public const long GL_COLOR_WRITEMASK = 0x0C23;
    public const long GL_CURRENT_INDEX = 0x0B01;
    public const long GL_CURRENT_COLOR = 0x0B00;
    public const long GL_CURRENT_NORMAL = 0x0B02;
    public const long GL_CURRENT_RASTER_COLOR = 0x0B04;
    public const long GL_CURRENT_RASTER_DISTANCE = 0x0B09;
    public const long GL_CURRENT_RASTER_INDEX = 0x0B05;
    public const long GL_CURRENT_RASTER_POSITION = 0x0B07;
    public const long GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
    public const long GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
    public const long GL_CURRENT_TEXTURE_COORDS = 0x0B03;
    public const long GL_INDEX_CLEAR_VALUE = 0x0C20;
    public const long GL_INDEX_MODE = 0x0C30;
    public const long GL_INDEX_WRITEMASK = 0x0C21;
    public const long GL_MODELVIEW_MATRIX = 0x0BA6;
    public const long GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
    public const long GL_NAME_STACK_DEPTH = 0x0D70;
    public const long GL_PROJECTION_MATRIX = 0x0BA7;
    public const long GL_PROJECTION_STACK_DEPTH = 0x0BA4;
    public const long GL_RENDER_MODE = 0x0C40;
    public const long GL_RGBA_MODE = 0x0C31;
    public const long GL_TEXTURE_MATRIX = 0x0BA8;
    public const long GL_TEXTURE_STACK_DEPTH = 0x0BA5;
    public const long GL_VIEWPORT = 0x0BA2;
    public const long GL_AUTO_NORMAL = 0x0D80;
    public const long GL_MAP1_COLOR_4 = 0x0D90;
    public const long GL_MAP1_INDEX = 0x0D91;
    public const long GL_MAP1_NORMAL = 0x0D92;
    public const long GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
    public const long GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
    public const long GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
    public const long GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
    public const long GL_MAP1_VERTEX_3 = 0x0D97;
    public const long GL_MAP1_VERTEX_4 = 0x0D98;
    public const long GL_MAP2_COLOR_4 = 0x0DB0;
    public const long GL_MAP2_INDEX = 0x0DB1;
    public const long GL_MAP2_NORMAL = 0x0DB2;
    public const long GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
    public const long GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
    public const long GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
    public const long GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
    public const long GL_MAP2_VERTEX_3 = 0x0DB7;
    public const long GL_MAP2_VERTEX_4 = 0x0DB8;
    public const long GL_MAP1_GRID_DOMAIN = 0x0DD0;
    public const long GL_MAP1_GRID_SEGMENTS = 0x0DD1;
    public const long GL_MAP2_GRID_DOMAIN = 0x0DD2;
    public const long GL_MAP2_GRID_SEGMENTS = 0x0DD3;
    public const long GL_COEFF = 0x0A00;
    public const long GL_ORDER = 0x0A01;
    public const long GL_DOMAIN = 0x0A02;
    public const long GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
    public const long GL_POINT_SMOOTH_HINT = 0x0C51;
    public const long GL_LINE_SMOOTH_HINT = 0x0C52;
    public const long GL_POLYGON_SMOOTH_HINT = 0x0C53;
    public const long GL_FOG_HINT = 0x0C54;
    public const long GL_DONT_CARE = 0x1100;
    public const long GL_FASTEST = 0x1101;
    public const long GL_NICEST = 0x1102;
    public const long GL_SCISSOR_BOX = 0x0C10;
    public const long GL_SCISSOR_TEST = 0x0C11;
    public const long GL_MAP_COLOR = 0x0D10;
    public const long GL_MAP_STENCIL = 0x0D11;
    public const long GL_INDEX_SHIFT = 0x0D12;
    public const long GL_INDEX_OFFSET = 0x0D13;
    public const long GL_RED_SCALE = 0x0D14;
    public const long GL_RED_BIAS = 0x0D15;
    public const long GL_GREEN_SCALE = 0x0D18;
    public const long GL_GREEN_BIAS = 0x0D19;
    public const long GL_BLUE_SCALE = 0x0D1A;
    public const long GL_BLUE_BIAS = 0x0D1B;
    public const long GL_ALPHA_SCALE = 0x0D1C;
    public const long GL_ALPHA_BIAS = 0x0D1D;
    public const long GL_DEPTH_SCALE = 0x0D1E;
    public const long GL_DEPTH_BIAS = 0x0D1F;
    public const long GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
    public const long GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
    public const long GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
    public const long GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
    public const long GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
    public const long GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
    public const long GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
    public const long GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
    public const long GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
    public const long GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
    public const long GL_PIXEL_MAP_S_TO_S = 0x0C71;
    public const long GL_PIXEL_MAP_I_TO_I = 0x0C70;
    public const long GL_PIXEL_MAP_I_TO_R = 0x0C72;
    public const long GL_PIXEL_MAP_I_TO_G = 0x0C73;
    public const long GL_PIXEL_MAP_I_TO_B = 0x0C74;
    public const long GL_PIXEL_MAP_I_TO_A = 0x0C75;
    public const long GL_PIXEL_MAP_R_TO_R = 0x0C76;
    public const long GL_PIXEL_MAP_G_TO_G = 0x0C77;
    public const long GL_PIXEL_MAP_B_TO_B = 0x0C78;
    public const long GL_PIXEL_MAP_A_TO_A = 0x0C79;
    public const long GL_PACK_ALIGNMENT = 0x0D05;
    public const long GL_PACK_LSB_FIRST = 0x0D01;
    public const long GL_PACK_ROW_LENGTH = 0x0D02;
    public const long GL_PACK_SKIP_PIXELS = 0x0D04;
    public const long GL_PACK_SKIP_ROWS = 0x0D03;
    public const long GL_PACK_SWAP_BYTES = 0x0D00;
    public const long GL_UNPACK_ALIGNMENT = 0x0CF5;
    public const long GL_UNPACK_LSB_FIRST = 0x0CF1;
    public const long GL_UNPACK_ROW_LENGTH = 0x0CF2;
    public const long GL_UNPACK_SKIP_PIXELS = 0x0CF4;
    public const long GL_UNPACK_SKIP_ROWS = 0x0CF3;
    public const long GL_UNPACK_SWAP_BYTES = 0x0CF0;
    public const long GL_ZOOM_X = 0x0D16;
    public const long GL_ZOOM_Y = 0x0D17;
    public const long GL_TEXTURE_ENV = 0x2300;
    public const long GL_TEXTURE_ENV_MODE = 0x2200;
    public const long GL_TEXTURE_1D = 0x0DE0;
    public const long GL_TEXTURE_2D = 0x0DE1;
    public const long GL_TEXTURE_WRAP_S = 0x2802;
    public const long GL_TEXTURE_WRAP_T = 0x2803;
    public const long GL_TEXTURE_MAG_FILTER = 0x2800;
    public const long GL_TEXTURE_MIN_FILTER = 0x2801;
    public const long GL_TEXTURE_ENV_COLOR = 0x2201;
    public const long GL_TEXTURE_GEN_S = 0x0C60;
    public const long GL_TEXTURE_GEN_T = 0x0C61;
    public const long GL_TEXTURE_GEN_R = 0x0C62;
    public const long GL_TEXTURE_GEN_Q = 0x0C63;
    public const long GL_TEXTURE_GEN_MODE = 0x2500;
    public const long GL_TEXTURE_BORDER_COLOR = 0x1004;
    public const long GL_TEXTURE_WIDTH = 0x1000;
    public const long GL_TEXTURE_HEIGHT = 0x1001;
    public const long GL_TEXTURE_BORDER = 0x1005;
    public const long GL_TEXTURE_COMPONENTS = 0x1003;
    public const long GL_TEXTURE_RED_SIZE = 0x805C;
    public const long GL_TEXTURE_GREEN_SIZE = 0x805D;
    public const long GL_TEXTURE_BLUE_SIZE = 0x805E;
    public const long GL_TEXTURE_ALPHA_SIZE = 0x805F;
    public const long GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
    public const long GL_TEXTURE_INTENSITY_SIZE = 0x8061;
    public const long GL_NEAREST_MIPMAP_NEAREST = 0x2700;
    public const long GL_NEAREST_MIPMAP_LINEAR = 0x2702;
    public const long GL_LINEAR_MIPMAP_NEAREST = 0x2701;
    public const long GL_LINEAR_MIPMAP_LINEAR = 0x2703;
    public const long GL_OBJECT_LINEAR = 0x2401;
    public const long GL_OBJECT_PLANE = 0x2501;
    public const long GL_EYE_LINEAR = 0x2400;
    public const long GL_EYE_PLANE = 0x2502;
    public const long GL_SPHERE_MAP = 0x2402;
    public const long GL_DECAL = 0x2101;
    public const long GL_MODULATE = 0x2100;
    public const long GL_NEAREST = 0x2600;
    public const long GL_REPEAT = 0x2901;
    public const long GL_CLAMP = 0x2900;
    public const long GL_S = 0x2000;
    public const long GL_T = 0x2001;
    public const long GL_R = 0x2002;
    public const long GL_Q = 0x2003;
    public const long GL_VENDOR = 0x1F00;
    public const long GL_RENDERER = 0x1F01;
    public const long GL_VERSION = 0x1F02;
    public const long GL_EXTENSIONS = 0x1F03;
    public const long GL_NO_ERROR = 0;
    public const long GL_INVALID_ENUM = 0x0500;
    public const long GL_INVALID_VALUE = 0x0501;
    public const long GL_INVALID_OPERATION = 0x0502;
    public const long GL_STACK_OVERFLOW = 0x0503;
    public const long GL_STACK_UNDERFLOW = 0x0504;
    public const long GL_OUT_OF_MEMORY = 0x0505;
    public const long GL_CURRENT_BIT = 0x00000001;
    public const long GL_POINT_BIT = 0x00000002;
    public const long GL_LINE_BIT = 0x00000004;
    public const long GL_POLYGON_BIT = 0x00000008;
    public const long GL_POLYGON_STIPPLE_BIT = 0x00000010;
    public const long GL_PIXEL_MODE_BIT = 0x00000020;
    public const long GL_LIGHTING_BIT = 0x00000040;
    public const long GL_FOG_BIT = 0x00000080;
    public const long GL_DEPTH_BUFFER_BIT = 0x00000100;
    public const long GL_ACCUM_BUFFER_BIT = 0x00000200;
    public const long GL_STENCIL_BUFFER_BIT = 0x00000400;
    public const long GL_VIEWPORT_BIT = 0x00000800;
    public const long GL_TRANSFORM_BIT = 0x00001000;
    public const long GL_ENABLE_BIT = 0x00002000;
    public const long GL_COLOR_BUFFER_BIT = 0x00004000;
    public const long GL_HINT_BIT = 0x00008000;
    public const long GL_EVAL_BIT = 0x00010000;
    public const long GL_LIST_BIT = 0x00020000;
    public const long GL_TEXTURE_BIT = 0x00040000;
    public const long GL_SCISSOR_BIT = 0x00080000;
    public const long GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;
    public const long GL_PROXY_TEXTURE_1D = 0x8063;
    public const long GL_PROXY_TEXTURE_2D = 0x8064;
    public const long GL_TEXTURE_PRIORITY = 0x8066;
    public const long GL_TEXTURE_RESIDENT = 0x8067;
    public const long GL_TEXTURE_BINDING_1D = 0x8068;
    public const long GL_TEXTURE_BINDING_2D = 0x8069;
    public const long GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
    public const long GL_ALPHA4 = 0x803B;
    public const long GL_ALPHA8 = 0x803C;
    public const long GL_ALPHA12 = 0x803D;
    public const long GL_ALPHA16 = 0x803E;
    public const long GL_LUMINANCE4 = 0x803F;
    public const long GL_LUMINANCE8 = 0x8040;
    public const long GL_LUMINANCE12 = 0x8041;
    public const long GL_LUMINANCE16 = 0x8042;
    public const long GL_LUMINANCE4_ALPHA4 = 0x8043;
    public const long GL_LUMINANCE6_ALPHA2 = 0x8044;
    public const long GL_LUMINANCE8_ALPHA8 = 0x8045;
    public const long GL_LUMINANCE12_ALPHA4 = 0x8046;
    public const long GL_LUMINANCE12_ALPHA12 = 0x8047;
    public const long GL_LUMINANCE16_ALPHA16 = 0x8048;
    public const long GL_INTENSITY = 0x8049;
    public const long GL_INTENSITY4 = 0x804A;
    public const long GL_INTENSITY8 = 0x804B;
    public const long GL_INTENSITY12 = 0x804C;
    public const long GL_INTENSITY16 = 0x804D;
    public const long GL_R3_G3_B2 = 0x2A10;
    public const long GL_RGB4 = 0x804F;
    public const long GL_RGB5 = 0x8050;
    public const long GL_RGB8 = 0x8051;
    public const long GL_RGB10 = 0x8052;
    public const long GL_RGB12 = 0x8053;
    public const long GL_RGB16 = 0x8054;
    public const long GL_RGBA2 = 0x8055;
    public const long GL_RGBA4 = 0x8056;
    public const long GL_RGB5_A1 = 0x8057;
    public const long GL_RGBA8 = 0x8058;
    public const long GL_RGB10_A2 = 0x8059;
    public const long GL_RGBA12 = 0x805A;
    public const long GL_RGBA16 = 0x805B;
    public const long GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
    public const long GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
    public const long GL_ALL_CLIENT_ATTRIB_BITS = 0xFFFFFFFF;
    public const long GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
    public const long GL_RESCALE_NORMAL = 0x803A;
    public const long GL_CLAMP_TO_EDGE = 0x812F;
    public const long GL_MAX_ELEMENTS_VERTICES = 0x80E8;
    public const long GL_MAX_ELEMENTS_INDICES = 0x80E9;
    public const long GL_BGR = 0x80E0;
    public const long GL_BGRA = 0x80E1;
    public const long GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
    public const long GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
    public const long GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
    public const long GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
    public const long GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
    public const long GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
    public const long GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
    public const long GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
    public const long GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
    public const long GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
    public const long GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
    public const long GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
    public const long GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
    public const long GL_SINGLE_COLOR = 0x81F9;
    public const long GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
    public const long GL_TEXTURE_MIN_LOD = 0x813A;
    public const long GL_TEXTURE_MAX_LOD = 0x813B;
    public const long GL_TEXTURE_BASE_LEVEL = 0x813C;
    public const long GL_TEXTURE_MAX_LEVEL = 0x813D;
    public const long GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
    public const long GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
    public const long GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
    public const long GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
    public const long GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
    public const long GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
    public const long GL_PACK_SKIP_IMAGES = 0x806B;
    public const long GL_PACK_IMAGE_HEIGHT = 0x806C;
    public const long GL_UNPACK_SKIP_IMAGES = 0x806D;
    public const long GL_UNPACK_IMAGE_HEIGHT = 0x806E;
    public const long GL_TEXTURE_3D = 0x806F;
    public const long GL_PROXY_TEXTURE_3D = 0x8070;
    public const long GL_TEXTURE_DEPTH = 0x8071;
    public const long GL_TEXTURE_WRAP_R = 0x8072;
    public const long GL_MAX_3D_TEXTURE_SIZE = 0x8073;
    public const long GL_TEXTURE_BINDING_3D = 0x806A;
    public const long GL_CONSTANT_COLOR = 0x8001;
    public const long GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
    public const long GL_CONSTANT_ALPHA = 0x8003;
    public const long GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
    public const long GL_COLOR_TABLE = 0x80D0;
    public const long GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
    public const long GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
    public const long GL_PROXY_COLOR_TABLE = 0x80D3;
    public const long GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
    public const long GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
    public const long GL_COLOR_TABLE_SCALE = 0x80D6;
    public const long GL_COLOR_TABLE_BIAS = 0x80D7;
    public const long GL_COLOR_TABLE_FORMAT = 0x80D8;
    public const long GL_COLOR_TABLE_WIDTH = 0x80D9;
    public const long GL_COLOR_TABLE_RED_SIZE = 0x80DA;
    public const long GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
    public const long GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
    public const long GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
    public const long GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
    public const long GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
    public const long GL_CONVOLUTION_1D = 0x8010;
    public const long GL_CONVOLUTION_2D = 0x8011;
    public const long GL_SEPARABLE_2D = 0x8012;
    public const long GL_CONVOLUTION_BORDER_MODE = 0x8013;
    public const long GL_CONVOLUTION_FILTER_SCALE = 0x8014;
    public const long GL_CONVOLUTION_FILTER_BIAS = 0x8015;
    public const long GL_REDUCE = 0x8016;
    public const long GL_CONVOLUTION_FORMAT = 0x8017;
    public const long GL_CONVOLUTION_WIDTH = 0x8018;
    public const long GL_CONVOLUTION_HEIGHT = 0x8019;
    public const long GL_MAX_CONVOLUTION_WIDTH = 0x801A;
    public const long GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
    public const long GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
    public const long GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
    public const long GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
    public const long GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
    public const long GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
    public const long GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
    public const long GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
    public const long GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
    public const long GL_CONSTANT_BORDER = 0x8151;
    public const long GL_REPLICATE_BORDER = 0x8153;
    public const long GL_CONVOLUTION_BORDER_COLOR = 0x8154;
    public const long GL_COLOR_MATRIX = 0x80B1;
    public const long GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
    public const long GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
    public const long GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
    public const long GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
    public const long GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
    public const long GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
    public const long GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
    public const long GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
    public const long GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
    public const long GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
    public const long GL_HISTOGRAM = 0x8024;
    public const long GL_PROXY_HISTOGRAM = 0x8025;
    public const long GL_HISTOGRAM_WIDTH = 0x8026;
    public const long GL_HISTOGRAM_FORMAT = 0x8027;
    public const long GL_HISTOGRAM_RED_SIZE = 0x8028;
    public const long GL_HISTOGRAM_GREEN_SIZE = 0x8029;
    public const long GL_HISTOGRAM_BLUE_SIZE = 0x802A;
    public const long GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
    public const long GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
    public const long GL_HISTOGRAM_SINK = 0x802D;
    public const long GL_MINMAX = 0x802E;
    public const long GL_MINMAX_FORMAT = 0x802F;
    public const long GL_MINMAX_SINK = 0x8030;
    public const long GL_TABLE_TOO_LARGE = 0x8031;
    public const long GL_BLEND_EQUATION = 0x8009;
    public const long GL_MIN = 0x8007;
    public const long GL_MAX = 0x8008;
    public const long GL_FUNC_ADD = 0x8006;
    public const long GL_FUNC_SUBTRACT = 0x800A;
    public const long GL_FUNC_REVERSE_SUBTRACT = 0x800B;
    public const long GL_BLEND_COLOR = 0x8005;
    public const long GL_TEXTURE0 = 0x84C0;
    public const long GL_TEXTURE1 = 0x84C1;
    public const long GL_TEXTURE2 = 0x84C2;
    public const long GL_TEXTURE3 = 0x84C3;
    public const long GL_TEXTURE4 = 0x84C4;
    public const long GL_TEXTURE5 = 0x84C5;
    public const long GL_TEXTURE6 = 0x84C6;
    public const long GL_TEXTURE7 = 0x84C7;
    public const long GL_TEXTURE8 = 0x84C8;
    public const long GL_TEXTURE9 = 0x84C9;
    public const long GL_TEXTURE10 = 0x84CA;
    public const long GL_TEXTURE11 = 0x84CB;
    public const long GL_TEXTURE12 = 0x84CC;
    public const long GL_TEXTURE13 = 0x84CD;
    public const long GL_TEXTURE14 = 0x84CE;
    public const long GL_TEXTURE15 = 0x84CF;
    public const long GL_TEXTURE16 = 0x84D0;
    public const long GL_TEXTURE17 = 0x84D1;
    public const long GL_TEXTURE18 = 0x84D2;
    public const long GL_TEXTURE19 = 0x84D3;
    public const long GL_TEXTURE20 = 0x84D4;
    public const long GL_TEXTURE21 = 0x84D5;
    public const long GL_TEXTURE22 = 0x84D6;
    public const long GL_TEXTURE23 = 0x84D7;
    public const long GL_TEXTURE24 = 0x84D8;
    public const long GL_TEXTURE25 = 0x84D9;
    public const long GL_TEXTURE26 = 0x84DA;
    public const long GL_TEXTURE27 = 0x84DB;
    public const long GL_TEXTURE28 = 0x84DC;
    public const long GL_TEXTURE29 = 0x84DD;
    public const long GL_TEXTURE30 = 0x84DE;
    public const long GL_TEXTURE31 = 0x84DF;
    public const long GL_ACTIVE_TEXTURE = 0x84E0;
    public const long GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
    public const long GL_MAX_TEXTURE_UNITS = 0x84E2;
    public const long GL_NORMAL_MAP = 0x8511;
    public const long GL_REFLECTION_MAP = 0x8512;
    public const long GL_TEXTURE_CUBE_MAP = 0x8513;
    public const long GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
    public const long GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
    public const long GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
    public const long GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
    public const long GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
    public const long GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
    public const long GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
    public const long GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
    public const long GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
    public const long GL_COMPRESSED_ALPHA = 0x84E9;
    public const long GL_COMPRESSED_LUMINANCE = 0x84EA;
    public const long GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
    public const long GL_COMPRESSED_INTENSITY = 0x84EC;
    public const long GL_COMPRESSED_RGB = 0x84ED;
    public const long GL_COMPRESSED_RGBA = 0x84EE;
    public const long GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
    public const long GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
    public const long GL_TEXTURE_COMPRESSED = 0x86A1;
    public const long GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
    public const long GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
    public const long GL_MULTISAMPLE = 0x809D;
    public const long GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
    public const long GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
    public const long GL_SAMPLE_COVERAGE = 0x80A0;
    public const long GL_SAMPLE_BUFFERS = 0x80A8;
    public const long GL_SAMPLES = 0x80A9;
    public const long GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
    public const long GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
    public const long GL_MULTISAMPLE_BIT = 0x20000000;
    public const long GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
    public const long GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
    public const long GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
    public const long GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
    public const long GL_COMBINE = 0x8570;
    public const long GL_COMBINE_RGB = 0x8571;
    public const long GL_COMBINE_ALPHA = 0x8572;
    public const long GL_SOURCE0_RGB = 0x8580;
    public const long GL_SOURCE1_RGB = 0x8581;
    public const long GL_SOURCE2_RGB = 0x8582;
    public const long GL_SOURCE0_ALPHA = 0x8588;
    public const long GL_SOURCE1_ALPHA = 0x8589;
    public const long GL_SOURCE2_ALPHA = 0x858A;
    public const long GL_OPERAND0_RGB = 0x8590;
    public const long GL_OPERAND1_RGB = 0x8591;
    public const long GL_OPERAND2_RGB = 0x8592;
    public const long GL_OPERAND0_ALPHA = 0x8598;
    public const long GL_OPERAND1_ALPHA = 0x8599;
    public const long GL_OPERAND2_ALPHA = 0x859A;
    public const long GL_RGB_SCALE = 0x8573;
    public const long GL_ADD_SIGNED = 0x8574;
    public const long GL_INTERPOLATE = 0x8575;
    public const long GL_SUBTRACT = 0x84E7;
    public const long GL_CONSTANT = 0x8576;
    public const long GL_PRIMARY_COLOR = 0x8577;
    public const long GL_PREVIOUS = 0x8578;
    public const long GL_DOT3_RGB = 0x86AE;
    public const long GL_DOT3_RGBA = 0x86AF;
    public const long GL_CLAMP_TO_BORDER = 0x812D;
    public const long GL_ARB_multitexture = 1;
    public const long GL_TEXTURE0_ARB = 0x84C0;
    public const long GL_TEXTURE1_ARB = 0x84C1;
    public const long GL_TEXTURE2_ARB = 0x84C2;
    public const long GL_TEXTURE3_ARB = 0x84C3;
    public const long GL_TEXTURE4_ARB = 0x84C4;
    public const long GL_TEXTURE5_ARB = 0x84C5;
    public const long GL_TEXTURE6_ARB = 0x84C6;
    public const long GL_TEXTURE7_ARB = 0x84C7;
    public const long GL_TEXTURE8_ARB = 0x84C8;
    public const long GL_TEXTURE9_ARB = 0x84C9;
    public const long GL_TEXTURE10_ARB = 0x84CA;
    public const long GL_TEXTURE11_ARB = 0x84CB;
    public const long GL_TEXTURE12_ARB = 0x84CC;
    public const long GL_TEXTURE13_ARB = 0x84CD;
    public const long GL_TEXTURE14_ARB = 0x84CE;
    public const long GL_TEXTURE15_ARB = 0x84CF;
    public const long GL_TEXTURE16_ARB = 0x84D0;
    public const long GL_TEXTURE17_ARB = 0x84D1;
    public const long GL_TEXTURE18_ARB = 0x84D2;
    public const long GL_TEXTURE19_ARB = 0x84D3;
    public const long GL_TEXTURE20_ARB = 0x84D4;
    public const long GL_TEXTURE21_ARB = 0x84D5;
    public const long GL_TEXTURE22_ARB = 0x84D6;
    public const long GL_TEXTURE23_ARB = 0x84D7;
    public const long GL_TEXTURE24_ARB = 0x84D8;
    public const long GL_TEXTURE25_ARB = 0x84D9;
    public const long GL_TEXTURE26_ARB = 0x84DA;
    public const long GL_TEXTURE27_ARB = 0x84DB;
    public const long GL_TEXTURE28_ARB = 0x84DC;
    public const long GL_TEXTURE29_ARB = 0x84DD;
    public const long GL_TEXTURE30_ARB = 0x84DE;
    public const long GL_TEXTURE31_ARB = 0x84DF;
    public const long GL_ACTIVE_TEXTURE_ARB = 0x84E0;
    public const long GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
    public const long GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;
    public const long GL_MESA_packed_depth_stencil = 1;
    public const long GL_DEPTH_STENCIL_MESA = 0x8750;
    public const long GL_UNSIGNED_INT_24_8_MESA = 0x8751;
    public const long GL_UNSIGNED_INT_8_24_REV_MESA = 0x8752;
    public const long GL_UNSIGNED_SHORT_15_1_MESA = 0x8753;
    public const long GL_UNSIGNED_SHORT_1_15_REV_MESA = 0x8754;
    public const long GL_ATI_blend_equation_separate = 1;
    public const long GL_ALPHA_BLEND_EQUATION_ATI = 0x883D;
    public const long GL_OES_EGL_image = 1;
    
    
    [DllImport(Lib)]
    public static unsafe extern void glClearIndex ( GLfloat c);
    
    [DllImport(Lib)]
    public static unsafe extern void glClearColor ( GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glClear ( GLbitfield mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexMask ( GLuint mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorMask ( GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glAlphaFunc ( GLenum func, GLclampf ref_);
    
    [DllImport(Lib)]
    public static unsafe extern void glBlendFunc ( GLenum sfactor, GLenum dfactor);
    
    [DllImport(Lib)]
    public static unsafe extern void glLogicOp ( GLenum opcode);
    
    [DllImport(Lib)]
    public static unsafe extern void glCullFace ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glFrontFace ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glPointSize ( GLfloat size);
    
    [DllImport(Lib)]
    public static unsafe extern void glLineWidth ( GLfloat width);
    
    [DllImport(Lib)]
    public static unsafe extern void glLineStipple ( GLint factor, GLushort pattern);
    
    [DllImport(Lib)]
    public static unsafe extern void glPolygonMode ( GLenum face, GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glPolygonOffset ( GLfloat factor, GLfloat units);
    
    [DllImport(Lib)]
    public static unsafe extern void glPolygonStipple ( System.IntPtr /*|GLubyte*|*/  mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetPolygonStipple ( System.IntPtr /*|GLubyte*|*/  mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glEdgeFlag ( GLboolean flag);
    
    [DllImport(Lib)]
    public static unsafe extern void glEdgeFlagv ( System.IntPtr /*|GLboolean*|*/  flag);
    
    [DllImport(Lib)]
    public static unsafe extern void glScissor ( GLint x, GLint y, GLsizei width, GLsizei height);
    
    [DllImport(Lib)]
    public static unsafe extern void glClipPlane ( GLenum plane, System.IntPtr /*|GLdouble*|*/  equation);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetClipPlane ( GLenum plane, System.IntPtr /*|GLdouble*|*/  equation);
    
    [DllImport(Lib)]
    public static unsafe extern void glDrawBuffer ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glReadBuffer ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glEnable ( GLenum cap);
    
    [DllImport(Lib)]
    public static unsafe extern void glDisable ( GLenum cap);
    
    [DllImport(Lib)]
    public static unsafe extern GLboolean glIsEnabled ( GLenum cap);
    
    [DllImport(Lib)]
    public static unsafe extern void glEnableClientState ( GLenum cap);
    
    [DllImport(Lib)]
    public static unsafe extern void glDisableClientState ( GLenum cap);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetBooleanv ( GLenum pname, System.IntPtr /*|GLboolean*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetDoublev ( GLenum pname, System.IntPtr /*|GLdouble*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetFloatv ( GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetIntegerv ( GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glPushAttrib ( GLbitfield mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glPopAttrib ();
    
    [DllImport(Lib)]
    public static unsafe extern void glPushClientAttrib ( GLbitfield mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glPopClientAttrib ();
    
    [DllImport(Lib)]
    public static unsafe extern GLint glRenderMode ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern GLenum glGetError ();
    
    [DllImport(Lib)]
    public static unsafe extern System.IntPtr /*|GLubyte*|*/  glGetString ( GLenum name);
    
    [DllImport(Lib)]
    public static unsafe extern void glFinish ();
    
    [DllImport(Lib)]
    public static unsafe extern void glFlush ();
    
    [DllImport(Lib)]
    public static unsafe extern void glHint ( GLenum target, GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glClearDepth ( GLclampd depth);
    
    [DllImport(Lib)]
    public static unsafe extern void glDepthFunc ( GLenum func);
    
    [DllImport(Lib)]
    public static unsafe extern void glDepthMask ( GLboolean flag);
    
    [DllImport(Lib)]
    public static unsafe extern void glDepthRange ( GLclampd near_val, GLclampd far_val);
    
    [DllImport(Lib)]
    public static unsafe extern void glClearAccum ( GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glAccum ( GLenum op, GLfloat value);
    
    [DllImport(Lib)]
    public static unsafe extern void glMatrixMode ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glOrtho ( GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble near_val, GLdouble far_val);
    
    [DllImport(Lib)]
    public static unsafe extern void glFrustum ( GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble near_val, GLdouble far_val);
    
    [DllImport(Lib)]
    public static unsafe extern void glViewport ( GLint x, GLint y, GLsizei width, GLsizei height);
    
    [DllImport(Lib)]
    public static unsafe extern void glPushMatrix ();
    
    [DllImport(Lib)]
    public static unsafe extern void glPopMatrix ();
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadIdentity ();
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadMatrixd ( System.IntPtr /*|GLdouble*|*/  m);
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadMatrixf ( System.IntPtr /*|GLfloat*|*/  m);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultMatrixd ( System.IntPtr /*|GLdouble*|*/  m);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultMatrixf ( System.IntPtr /*|GLfloat*|*/  m);
    
    [DllImport(Lib)]
    public static unsafe extern void glRotated ( GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
    
    [DllImport(Lib)]
    public static unsafe extern void glRotatef ( GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
    
    [DllImport(Lib)]
    public static unsafe extern void glScaled ( GLdouble x, GLdouble y, GLdouble z);
    
    [DllImport(Lib)]
    public static unsafe extern void glScalef ( GLfloat x, GLfloat y, GLfloat z);
    
    [DllImport(Lib)]
    public static unsafe extern void glTranslated ( GLdouble x, GLdouble y, GLdouble z);
    
    [DllImport(Lib)]
    public static unsafe extern void glTranslatef ( GLfloat x, GLfloat y, GLfloat z);
    
    [DllImport(Lib)]
    public static unsafe extern GLboolean glIsList ( GLuint list);
    
    [DllImport(Lib)]
    public static unsafe extern void glDeleteLists ( GLuint list, GLsizei range);
    
    [DllImport(Lib)]
    public static unsafe extern GLuint glGenLists ( GLsizei range);
    
    [DllImport(Lib)]
    public static unsafe extern void glNewList ( GLuint list, GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glEndList ();
    
    [DllImport(Lib)]
    public static unsafe extern void glCallList ( GLuint list);
    
    [DllImport(Lib)]
    public static unsafe extern void glCallLists ( GLsizei n, GLenum type, System.IntPtr /*|GLvoid*|*/  lists);
    
    [DllImport(Lib)]
    public static unsafe extern void glListBase ( GLuint base_);
    
    [DllImport(Lib)]
    public static unsafe extern void glBegin ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glEnd ();
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2d ( GLdouble x, GLdouble y);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2f ( GLfloat x, GLfloat y);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2i ( GLint x, GLint y);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2s ( GLshort x, GLshort y);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3d ( GLdouble x, GLdouble y, GLdouble z);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3f ( GLfloat x, GLfloat y, GLfloat z);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3i ( GLint x, GLint y, GLint z);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3s ( GLshort x, GLshort y, GLshort z);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4d ( GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4f ( GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4i ( GLint x, GLint y, GLint z, GLint w);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4s ( GLshort x, GLshort y, GLshort z, GLshort w);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex2sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex3sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertex4sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3b ( GLbyte nx, GLbyte ny, GLbyte nz);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3d ( GLdouble nx, GLdouble ny, GLdouble nz);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3f ( GLfloat nx, GLfloat ny, GLfloat nz);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3i ( GLint nx, GLint ny, GLint nz);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3s ( GLshort nx, GLshort ny, GLshort nz);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3bv ( System.IntPtr /*|GLbyte*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormal3sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexd ( GLdouble c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexf ( GLfloat c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexi ( GLint c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexs ( GLshort c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexub ( GLubyte c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexdv ( System.IntPtr /*|GLdouble*|*/  c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexfv ( System.IntPtr /*|GLfloat*|*/  c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexiv ( System.IntPtr /*|GLint*|*/  c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexsv ( System.IntPtr /*|GLshort*|*/  c);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexubv ( System.IntPtr /*|GLubyte*|*/  c);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3b ( GLbyte red, GLbyte green, GLbyte blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3d ( GLdouble red, GLdouble green, GLdouble blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3f ( GLfloat red, GLfloat green, GLfloat blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3i ( GLint red, GLint green, GLint blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3s ( GLshort red, GLshort green, GLshort blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3ub ( GLubyte red, GLubyte green, GLubyte blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3ui ( GLuint red, GLuint green, GLuint blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3us ( GLushort red, GLushort green, GLushort blue);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4b ( GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4d ( GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4f ( GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4i ( GLint red, GLint green, GLint blue, GLint alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4s ( GLshort red, GLshort green, GLshort blue, GLshort alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4ub ( GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4ui ( GLuint red, GLuint green, GLuint blue, GLuint alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4us ( GLushort red, GLushort green, GLushort blue, GLushort alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3bv ( System.IntPtr /*|GLbyte*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3ubv ( System.IntPtr /*|GLubyte*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3uiv ( System.IntPtr /*|GLuint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor3usv ( System.IntPtr /*|GLushort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4bv ( System.IntPtr /*|GLbyte*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4ubv ( System.IntPtr /*|GLubyte*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4uiv ( System.IntPtr /*|GLuint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glColor4usv ( System.IntPtr /*|GLushort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1d ( GLdouble s);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1f ( GLfloat s);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1i ( GLint s);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1s ( GLshort s);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2d ( GLdouble s, GLdouble t);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2f ( GLfloat s, GLfloat t);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2i ( GLint s, GLint t);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2s ( GLshort s, GLshort t);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3d ( GLdouble s, GLdouble t, GLdouble r);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3f ( GLfloat s, GLfloat t, GLfloat r);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3i ( GLint s, GLint t, GLint r);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3s ( GLshort s, GLshort t, GLshort r);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4d ( GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4f ( GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4i ( GLint s, GLint t, GLint r, GLint q);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4s ( GLshort s, GLshort t, GLshort r, GLshort q);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord1sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord2sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord3sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoord4sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2d ( GLdouble x, GLdouble y);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2f ( GLfloat x, GLfloat y);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2i ( GLint x, GLint y);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2s ( GLshort x, GLshort y);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3d ( GLdouble x, GLdouble y, GLdouble z);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3f ( GLfloat x, GLfloat y, GLfloat z);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3i ( GLint x, GLint y, GLint z);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3s ( GLshort x, GLshort y, GLshort z);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4d ( GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4f ( GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4i ( GLint x, GLint y, GLint z, GLint w);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4s ( GLshort x, GLshort y, GLshort z, GLshort w);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos2sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos3sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4dv ( System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4fv ( System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4iv ( System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRasterPos4sv ( System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectd ( GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectf ( GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRecti ( GLint x1, GLint y1, GLint x2, GLint y2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRects ( GLshort x1, GLshort y1, GLshort x2, GLshort y2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectdv ( System.IntPtr /*|GLdouble*|*/  v1, System.IntPtr /*|GLdouble*|*/  v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectfv ( System.IntPtr /*|GLfloat*|*/  v1, System.IntPtr /*|GLfloat*|*/  v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectiv ( System.IntPtr /*|GLint*|*/  v1, System.IntPtr /*|GLint*|*/  v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glRectsv ( System.IntPtr /*|GLshort*|*/  v1, System.IntPtr /*|GLshort*|*/  v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glVertexPointer ( GLint size, GLenum type, GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glNormalPointer ( GLenum type, GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorPointer ( GLint size, GLenum type, GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glIndexPointer ( GLenum type, GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexCoordPointer ( GLint size, GLenum type, GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glEdgeFlagPointer ( GLsizei stride, System.IntPtr /*|GLvoid*|*/  ptr);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetPointerv ( GLenum pname, System.IntPtr /*|GLvoid**|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glArrayElement ( GLint i);
    
    [DllImport(Lib)]
    public static unsafe extern void glDrawArrays ( GLenum mode, GLint first, GLsizei count);
    
    [DllImport(Lib)]
    public static unsafe extern void glDrawElements ( GLenum mode, GLsizei count, GLenum type, System.IntPtr /*|GLvoid*|*/  indices);
    
    [DllImport(Lib)]
    public static unsafe extern void glInterleavedArrays ( GLenum format, GLsizei stride, System.IntPtr /*|GLvoid*|*/  pointer);
    
    [DllImport(Lib)]
    public static unsafe extern void glShadeModel ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightf ( GLenum light, GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glLighti ( GLenum light, GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightfv ( GLenum light, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightiv ( GLenum light, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetLightfv ( GLenum light, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetLightiv ( GLenum light, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightModelf ( GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightModeli ( GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightModelfv ( GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glLightModeliv ( GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glMaterialf ( GLenum face, GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glMateriali ( GLenum face, GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glMaterialfv ( GLenum face, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glMaterialiv ( GLenum face, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMaterialfv ( GLenum face, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMaterialiv ( GLenum face, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorMaterial ( GLenum face, GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelZoom ( GLfloat xfactor, GLfloat yfactor);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelStoref ( GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelStorei ( GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelTransferf ( GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelTransferi ( GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelMapfv ( GLenum map, GLsizei mapsize, System.IntPtr /*|GLfloat*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelMapuiv ( GLenum map, GLsizei mapsize, System.IntPtr /*|GLuint*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glPixelMapusv ( GLenum map, GLsizei mapsize, System.IntPtr /*|GLushort*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetPixelMapfv ( GLenum map, System.IntPtr /*|GLfloat*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetPixelMapuiv ( GLenum map, System.IntPtr /*|GLuint*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetPixelMapusv ( GLenum map, System.IntPtr /*|GLushort*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glBitmap ( GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, System.IntPtr /*|GLubyte*|*/  bitmap);
    
    [DllImport(Lib)]
    public static unsafe extern void glReadPixels ( GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glDrawPixels ( GLsizei width, GLsizei height, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyPixels ( GLint x, GLint y, GLsizei width, GLsizei height, GLenum type);
    
    [DllImport(Lib)]
    public static unsafe extern void glStencilFunc ( GLenum func, GLint ref_, GLuint mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glStencilMask ( GLuint mask);
    
    [DllImport(Lib)]
    public static unsafe extern void glStencilOp ( GLenum fail, GLenum zfail, GLenum zpass);
    
    [DllImport(Lib)]
    public static unsafe extern void glClearStencil ( GLint s);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGend ( GLenum coord, GLenum pname, GLdouble param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGenf ( GLenum coord, GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGeni ( GLenum coord, GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGendv ( GLenum coord, GLenum pname, System.IntPtr /*|GLdouble*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGenfv ( GLenum coord, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexGeniv ( GLenum coord, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexGendv ( GLenum coord, GLenum pname, System.IntPtr /*|GLdouble*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexGenfv ( GLenum coord, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexGeniv ( GLenum coord, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexEnvf ( GLenum target, GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexEnvi ( GLenum target, GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexEnvfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexEnviv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexEnvfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexEnviv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexParameterf ( GLenum target, GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexParameteri ( GLenum target, GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexLevelParameterfv ( GLenum target, GLint level, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexLevelParameteriv ( GLenum target, GLint level, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexImage1D ( GLenum target, GLint level, GLint internalFormat, GLsizei width, GLint border, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexImage2D ( GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetTexImage ( GLenum target, GLint level, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glGenTextures ( GLsizei n, System.IntPtr /*|GLuint*|*/  textures);
    
    [DllImport(Lib)]
    public static unsafe extern void glDeleteTextures ( GLsizei n, System.IntPtr /*|GLuint*|*/  textures);
    
    [DllImport(Lib)]
    public static unsafe extern void glBindTexture ( GLenum target, GLuint texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glPrioritizeTextures ( GLsizei n, System.IntPtr /*|GLuint*|*/  textures, System.IntPtr /*|GLclampf*|*/  priorities);
    
    [DllImport(Lib)]
    public static unsafe extern GLboolean glAreTexturesResident ( GLsizei n, System.IntPtr /*|GLuint*|*/  textures, System.IntPtr /*|GLboolean*|*/  residences);
    
    [DllImport(Lib)]
    public static unsafe extern GLboolean glIsTexture ( GLuint texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexSubImage1D ( GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexSubImage2D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyTexImage1D ( GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyTexImage2D ( GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyTexSubImage1D ( GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyTexSubImage2D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
    
    [DllImport(Lib)]
    public static unsafe extern void glMap1d ( GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, System.IntPtr /*|GLdouble*|*/  points);
    
    [DllImport(Lib)]
    public static unsafe extern void glMap1f ( GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, System.IntPtr /*|GLfloat*|*/  points);
    
    [DllImport(Lib)]
    public static unsafe extern void glMap2d ( GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, System.IntPtr /*|GLdouble*|*/  points);
    
    [DllImport(Lib)]
    public static unsafe extern void glMap2f ( GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, System.IntPtr /*|GLfloat*|*/  points);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMapdv ( GLenum target, GLenum query, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMapfv ( GLenum target, GLenum query, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMapiv ( GLenum target, GLenum query, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord1d ( GLdouble u);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord1f ( GLfloat u);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord1dv ( System.IntPtr /*|GLdouble*|*/  u);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord1fv ( System.IntPtr /*|GLfloat*|*/  u);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord2d ( GLdouble u, GLdouble v);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord2f ( GLfloat u, GLfloat v);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord2dv ( System.IntPtr /*|GLdouble*|*/  u);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalCoord2fv ( System.IntPtr /*|GLfloat*|*/  u);
    
    [DllImport(Lib)]
    public static unsafe extern void glMapGrid1d ( GLint un, GLdouble u1, GLdouble u2);
    
    [DllImport(Lib)]
    public static unsafe extern void glMapGrid1f ( GLint un, GLfloat u1, GLfloat u2);
    
    [DllImport(Lib)]
    public static unsafe extern void glMapGrid2d ( GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glMapGrid2f ( GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalPoint1 ( GLint i);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalPoint2 ( GLint i, GLint j);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalMesh1 ( GLenum mode, GLint i1, GLint i2);
    
    [DllImport(Lib)]
    public static unsafe extern void glEvalMesh2 ( GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);
    
    [DllImport(Lib)]
    public static unsafe extern void glFogf ( GLenum pname, GLfloat param);
    
    [DllImport(Lib)]
    public static unsafe extern void glFogi ( GLenum pname, GLint param);
    
    [DllImport(Lib)]
    public static unsafe extern void glFogfv ( GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glFogiv ( GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glFeedbackBuffer ( GLsizei size, GLenum type, System.IntPtr /*|GLfloat*|*/  buffer);
    
    [DllImport(Lib)]
    public static unsafe extern void glPassThrough ( GLfloat token);
    
    [DllImport(Lib)]
    public static unsafe extern void glSelectBuffer ( GLsizei size, System.IntPtr /*|GLuint*|*/  buffer);
    
    [DllImport(Lib)]
    public static unsafe extern void glInitNames ();
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadName ( GLuint name);
    
    [DllImport(Lib)]
    public static unsafe extern void glPushName ( GLuint name);
    
    [DllImport(Lib)]
    public static unsafe extern void glPopName ();
    
    [DllImport(Lib)]
    public static unsafe extern void glDrawRangeElements ( GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, System.IntPtr /*|GLvoid*|*/  indices);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexImage3D ( GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glTexSubImage3D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  pixels);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyTexSubImage3D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorTable ( GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  table);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorSubTable ( GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorTableParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glColorTableParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyColorSubTable ( GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyColorTable ( GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetColorTable ( GLenum target, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  table);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetColorTableParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetColorTableParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glBlendEquation ( GLenum mode);
    
    [DllImport(Lib)]
    public static unsafe extern void glBlendColor ( GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
    
    [DllImport(Lib)]
    public static unsafe extern void glHistogram ( GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
    
    [DllImport(Lib)]
    public static unsafe extern void glResetHistogram ( GLenum target);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetHistogram ( GLenum target, GLboolean reset, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetHistogramParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetHistogramParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glMinmax ( GLenum target, GLenum internalformat, GLboolean sink);
    
    [DllImport(Lib)]
    public static unsafe extern void glResetMinmax ( GLenum target);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMinmax ( GLenum target, GLboolean reset, GLenum format, GLenum types, System.IntPtr /*|GLvoid*|*/  values);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMinmaxParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetMinmaxParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionFilter1D ( GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  image);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionFilter2D ( GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  image);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionParameterf ( GLenum target, GLenum pname, GLfloat params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionParameteri ( GLenum target, GLenum pname, GLint params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glConvolutionParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyConvolutionFilter1D ( GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    
    [DllImport(Lib)]
    public static unsafe extern void glCopyConvolutionFilter2D ( GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetConvolutionFilter ( GLenum target, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  image);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetConvolutionParameterfv ( GLenum target, GLenum pname, System.IntPtr /*|GLfloat*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetConvolutionParameteriv ( GLenum target, GLenum pname, System.IntPtr /*|GLint*|*/  params_);
    
    [DllImport(Lib)]
    public static unsafe extern void glSeparableFilter2D ( GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  row, System.IntPtr /*|GLvoid*|*/  column);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetSeparableFilter ( GLenum target, GLenum format, GLenum type, System.IntPtr /*|GLvoid*|*/  row, System.IntPtr /*|GLvoid*|*/  column, System.IntPtr /*|GLvoid*|*/  span);
    
    [DllImport(Lib)]
    public static unsafe extern void glActiveTexture ( GLenum texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glClientActiveTexture ( GLenum texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexImage1D ( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexImage2D ( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexImage3D ( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexSubImage1D ( GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexSubImage2D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glCompressedTexSubImage3D ( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, System.IntPtr /*|GLvoid*|*/  data);
    
    [DllImport(Lib)]
    public static unsafe extern void glGetCompressedTexImage ( GLenum target, GLint lod, System.IntPtr /*|GLvoid*|*/  img);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1d ( GLenum target, GLdouble s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1dv ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1f ( GLenum target, GLfloat s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1fv ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1i ( GLenum target, GLint s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1iv ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1s ( GLenum target, GLshort s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1sv ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2d ( GLenum target, GLdouble s, GLdouble t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2dv ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2f ( GLenum target, GLfloat s, GLfloat t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2fv ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2i ( GLenum target, GLint s, GLint t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2iv ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2s ( GLenum target, GLshort s, GLshort t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2sv ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3d ( GLenum target, GLdouble s, GLdouble t, GLdouble r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3dv ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3f ( GLenum target, GLfloat s, GLfloat t, GLfloat r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3fv ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3i ( GLenum target, GLint s, GLint t, GLint r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3iv ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3s ( GLenum target, GLshort s, GLshort t, GLshort r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3sv ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4d ( GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4dv ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4f ( GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4fv ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4i ( GLenum target, GLint s, GLint t, GLint r, GLint q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4iv ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4s ( GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4sv ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadTransposeMatrixd ( GLdouble* m);
    
    [DllImport(Lib)]
    public static unsafe extern void glLoadTransposeMatrixf ( GLfloat* m);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultTransposeMatrixd ( GLdouble* m);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultTransposeMatrixf ( GLfloat* m);
    
    [DllImport(Lib)]
    public static unsafe extern void glSampleCoverage ( GLclampf value, GLboolean invert);
    
    [DllImport(Lib)]
    public static unsafe extern void glActiveTextureARB ( GLenum texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glClientActiveTextureARB ( GLenum texture);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1dARB ( GLenum target, GLdouble s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1dvARB ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1fARB ( GLenum target, GLfloat s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1fvARB ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1iARB ( GLenum target, GLint s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1ivARB ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1sARB ( GLenum target, GLshort s);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord1svARB ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2dARB ( GLenum target, GLdouble s, GLdouble t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2dvARB ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2fARB ( GLenum target, GLfloat s, GLfloat t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2fvARB ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2iARB ( GLenum target, GLint s, GLint t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2ivARB ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2sARB ( GLenum target, GLshort s, GLshort t);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord2svARB ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3dARB ( GLenum target, GLdouble s, GLdouble t, GLdouble r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3dvARB ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3fARB ( GLenum target, GLfloat s, GLfloat t, GLfloat r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3fvARB ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3iARB ( GLenum target, GLint s, GLint t, GLint r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3ivARB ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3sARB ( GLenum target, GLshort s, GLshort t, GLshort r);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord3svARB ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4dARB ( GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4dvARB ( GLenum target, System.IntPtr /*|GLdouble*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4fARB ( GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4fvARB ( GLenum target, System.IntPtr /*|GLfloat*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4iARB ( GLenum target, GLint s, GLint t, GLint r, GLint q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4ivARB ( GLenum target, System.IntPtr /*|GLint*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4sARB ( GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
    
    [DllImport(Lib)]
    public static unsafe extern void glMultiTexCoord4svARB ( GLenum target, System.IntPtr /*|GLshort*|*/  v);
    
    [DllImport(Lib)]
    public static unsafe extern void glBlendEquationSeparateATI ( GLenum modeRGB, GLenum modeA);
    
    
}
/* errors:
*/
