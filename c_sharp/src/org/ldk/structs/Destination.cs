using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The destination of an onion message.
 */
public class Destination : CommonBase {
	protected Destination(object _dummy, long ptr) : base(ptr) { }
	~Destination() {
		if (ptr != 0) { Bindings.DestinationFree(ptr); }
	}

	internal static Destination constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKDestinationTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Destination_Node(ptr);
			case 1: return new Destination_BlindedPath(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Destination of type Node */
	public class Destination_Node : Destination {
		public byte[] node;
		internal Destination_Node(long ptr) : base(null, ptr) {
			long node = Bindings.LDKDestinationNodeGetNode(ptr);
			byte[] node_conv = InternalUtils.DecodeUint8Array(node);
			this.node = node_conv;
		}
	}
	/** A Destination of type BlindedPath */
	public class Destination_BlindedPath : Destination {
		public BlindedPath blinded_path;
		internal Destination_BlindedPath(long ptr) : base(null, ptr) {
			long blinded_path = Bindings.LDKDestinationBlindedPathGetBlindedPath(ptr);
			org.ldk.structs.BlindedPath blinded_path_hu_conv = null; if (blinded_path < 0 || blinded_path > 4096) { blinded_path_hu_conv = new org.ldk.structs.BlindedPath(null, blinded_path); }
			if (blinded_path_hu_conv != null) { blinded_path_hu_conv.ptrs_to.AddLast(this); };
			this.blinded_path = blinded_path_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.DestinationClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Destination
	 */
	public Destination clone() {
		long ret = Bindings.DestinationClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Node-variant Destination
	 */
	public static Destination node(byte[] a) {
		long ret = Bindings.DestinationNode(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 33)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BlindedPath-variant Destination
	 */
	public static Destination blinded_path(org.ldk.structs.BlindedPath a) {
		long ret = Bindings.DestinationBlindedPath(a == null ? 0 : a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Destination ret_hu_conv = org.ldk.structs.Destination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

}
} } }
