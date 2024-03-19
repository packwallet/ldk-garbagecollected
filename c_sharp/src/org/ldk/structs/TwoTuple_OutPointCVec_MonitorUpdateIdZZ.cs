using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_OutPointCVec_MonitorUpdateIdZZ : CommonBase {
	internal TwoTuple_OutPointCVec_MonitorUpdateIdZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_OutPointCVec_MonitorUpdateIdZZ() {
		if (ptr != 0) { Bindings.C2TupleOutPointCVecMonitorUpdateIdZZFree(ptr); }
	}

	/**
	 * 
	 */
	public OutPoint get_a() {
		long ret = Bindings.C2TupleOutPointCVecMonitorUpdateIdZZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public MonitorUpdateId[] get_b() {
		long ret = Bindings.C2TupleOutPointCVecMonitorUpdateIdZZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_17_len = InternalUtils.GetArrayLength(ret);
		MonitorUpdateId[] ret_conv_17_arr = new MonitorUpdateId[ret_conv_17_len];
		for (int r = 0; r < ret_conv_17_len; r++) {
			long ret_conv_17 = InternalUtils.GetU64ArrayElem(ret, r);
			org.ldk.structs.MonitorUpdateId ret_conv_17_hu_conv = null; if (ret_conv_17 < 0 || ret_conv_17 > 4096) { ret_conv_17_hu_conv = new org.ldk.structs.MonitorUpdateId(null, ret_conv_17); }
			if (ret_conv_17_hu_conv != null) { ret_conv_17_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_17_arr[r] = ret_conv_17_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_17_arr;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleOutPointCVecMonitorUpdateIdZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_OutPointCVec_MonitorUpdateIdZZ clone() {
		long ret = Bindings.C2TupleOutPointCVecMonitorUpdateIdZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointCVec_MonitorUpdateIdZZ ret_hu_conv = new TwoTuple_OutPointCVec_MonitorUpdateIdZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_OutPointCVec_MonitorUpdateIdZZ from the contained elements.
	 */
	public static TwoTuple_OutPointCVec_MonitorUpdateIdZZ of(org.ldk.structs.OutPoint a, MonitorUpdateId[] b) {
		long ret = Bindings.C2TupleOutPointCVecMonitorUpdateIdZZNew(a == null ? 0 : a.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(b, b_conv_17 => b_conv_17 == null ? 0 : b_conv_17.ptr)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointCVec_MonitorUpdateIdZZ ret_hu_conv = new TwoTuple_OutPointCVec_MonitorUpdateIdZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		foreach (MonitorUpdateId b_conv_17 in b) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b_conv_17); }; };
		return ret_hu_conv;
	}

}
} } }
