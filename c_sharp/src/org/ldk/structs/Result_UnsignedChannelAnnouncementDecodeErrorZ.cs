using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UnsignedChannelAnnouncementDecodeErrorZ : CommonBase {
	Result_UnsignedChannelAnnouncementDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UnsignedChannelAnnouncementDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZFree(ptr); }
	}

	internal static Result_UnsignedChannelAnnouncementDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZIsOk(ptr)) {
			return new Result_UnsignedChannelAnnouncementDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UnsignedChannelAnnouncementDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UnsignedChannelAnnouncementDecodeErrorZ_OK : Result_UnsignedChannelAnnouncementDecodeErrorZ {
		public readonly UnsignedChannelAnnouncement res;
		internal Result_UnsignedChannelAnnouncementDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZGetOk(ptr);
			org.ldk.structs.UnsignedChannelAnnouncement res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UnsignedChannelAnnouncement(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UnsignedChannelAnnouncementDecodeErrorZ_Err : Result_UnsignedChannelAnnouncementDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UnsignedChannelAnnouncementDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UnsignedChannelAnnouncementDecodeErrorZ in the success state.
	 */
	public static Result_UnsignedChannelAnnouncementDecodeErrorZ ok(org.ldk.structs.UnsignedChannelAnnouncement o) {
		long ret = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelAnnouncementDecodeErrorZ ret_hu_conv = Result_UnsignedChannelAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UnsignedChannelAnnouncementDecodeErrorZ in the error state.
	 */
	public static Result_UnsignedChannelAnnouncementDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelAnnouncementDecodeErrorZ ret_hu_conv = Result_UnsignedChannelAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UnsignedChannelAnnouncementDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UnsignedChannelAnnouncementDecodeErrorZ clone() {
		long ret = Bindings.CResultUnsignedChannelAnnouncementDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelAnnouncementDecodeErrorZ ret_hu_conv = Result_UnsignedChannelAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
