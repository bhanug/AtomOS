﻿using System;

namespace Atomix.Kernel_H.Lib.Cairo
{
    /* typedef enum _cairo_format {
     *      CAIRO_FORMAT_INVALID   = -1,
     *      CAIRO_FORMAT_ARGB32    = 0,
     *      CAIRO_FORMAT_RGB24     = 1,
     *      CAIRO_FORMAT_A8        = 2,
     *      CAIRO_FORMAT_A1        = 3,
     *      CAIRO_FORMAT_RGB16_565 = 4,
     *      CAIRO_FORMAT_RGB30     = 5
     * } cairo_format_t;
     */
    /* typedef enum _cairo_status {
     *      CAIRO_STATUS_SUCCESS = 0,
     *      CAIRO_STATUS_NO_MEMORY,
     *      CAIRO_STATUS_INVALID_RESTORE,
     *      CAIRO_STATUS_INVALID_POP_GROUP,
     *      CAIRO_STATUS_NO_CURRENT_POINT,
     *      CAIRO_STATUS_INVALID_MATRIX,
     *      CAIRO_STATUS_INVALID_STATUS,
     *      CAIRO_STATUS_NULL_POINTER,
     *      CAIRO_STATUS_INVALID_STRING,
     *      CAIRO_STATUS_INVALID_PATH_DATA,
     *      CAIRO_STATUS_READ_ERROR,
     *      CAIRO_STATUS_WRITE_ERROR,
     *      CAIRO_STATUS_SURFACE_FINISHED,
     *      CAIRO_STATUS_SURFACE_TYPE_MISMATCH,
     *      CAIRO_STATUS_PATTERN_TYPE_MISMATCH,
     *      CAIRO_STATUS_INVALID_CONTENT,
     *      CAIRO_STATUS_INVALID_FORMAT,
     *      CAIRO_STATUS_INVALID_VISUAL,
     *      CAIRO_STATUS_FILE_NOT_FOUND,
     *      CAIRO_STATUS_INVALID_DASH,
     *      CAIRO_STATUS_INVALID_DSC_COMMENT,
     *      CAIRO_STATUS_INVALID_INDEX,
     *      CAIRO_STATUS_CLIP_NOT_REPRESENTABLE,
     *      CAIRO_STATUS_TEMP_FILE_ERROR,
     *      CAIRO_STATUS_INVALID_STRIDE,
     *      CAIRO_STATUS_FONT_TYPE_MISMATCH,
     *      CAIRO_STATUS_USER_FONT_IMMUTABLE,
     *      CAIRO_STATUS_USER_FONT_ERROR,
     *      CAIRO_STATUS_NEGATIVE_COUNT,
     *      CAIRO_STATUS_INVALID_CLUSTERS,
     *      CAIRO_STATUS_INVALID_SLANT,
     *      CAIRO_STATUS_INVALID_WEIGHT,
     *      CAIRO_STATUS_INVALID_SIZE,
     *      CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED,
     *      CAIRO_STATUS_DEVICE_TYPE_MISMATCH,
     *      CAIRO_STATUS_DEVICE_ERROR,
     *      CAIRO_STATUS_INVALID_MESH_CONSTRUCTION,
     *      CAIRO_STATUS_DEVICE_FINISHED,
     *      CAIRO_STATUS_LAST_STATUS
     * } cairo_status_t;
     */

    [Serializable]
    internal enum Status
    {
        Success = 0,
        NoMemory,
        InvalidRestore,
        InvalidPopGroup,
        NoCurrentPoint,
        InvalidMatrix,
        InvalidStatus,
        NullPointer,
        InvalidString,
        InvalidPathData,
        ReadError,
        WriteError,
        SurfaceFinished,
        SurfaceTypeMismatch,
        PatternTypeMismatch,
        InvalidContent,
        InvalidFormat,
        InvalidVisual,
        FileNotFound,
        InvalidDash,
        InvalidDscComment,
        InvalidIndex,
        ClipNotRepresentable,
    }
}
