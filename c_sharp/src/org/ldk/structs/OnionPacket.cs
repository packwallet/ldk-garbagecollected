using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * BOLT 4 onion packet including hop data for the next peer.
 */
public class OnionPacket : CommonBase {
	internal OnionPacket(object _dummy, long ptr) : base(ptr) { }
	~OnionPacket() {
		if (ptr != 0) { Bindings.OnionPacketFree(ptr); }
	}

	/**
	 * BOLT 4 version number.
	 */
	public byte get_version() {
		byte ret = Bindings.OnionPacketGetVersion(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * BOLT 4 version number.
	 */
	public void set_version(byte val) {
		Bindings.OnionPacketSetVersion(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * In order to ensure we always return an error on onion decode in compliance with [BOLT
	 * #4](https://github.com/lightning/bolts/blob/master/04-onion-routing.md), we have to
	 * deserialize `OnionPacket`s contained in [`UpdateAddHTLC`] messages even if the ephemeral
	 * public key (here) is bogus, so we hold a [`Result`] instead of a [`PublicKey`] as we'd
	 * like.
	 * 
	 * Returns a copy of the field.
	 */
	public Result_PublicKeySecp256k1ErrorZ get_public_key() {
		long ret = Bindings.OnionPacketGetPublicKey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeySecp256k1ErrorZ ret_hu_conv = Result_PublicKeySecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * In order to ensure we always return an error on onion decode in compliance with [BOLT
	 * #4](https://github.com/lightning/bolts/blob/master/04-onion-routing.md), we have to
	 * deserialize `OnionPacket`s contained in [`UpdateAddHTLC`] messages even if the ephemeral
	 * public key (here) is bogus, so we hold a [`Result`] instead of a [`PublicKey`] as we'd
	 * like.
	 */
	public void set_public_key(org.ldk.structs.Result_PublicKeySecp256k1ErrorZ val) {
		Bindings.OnionPacketSetPublicKey(this.ptr, val != null ? val.ptr : 0);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * HMAC to verify the integrity of hop_data.
	 */
	public byte[] get_hmac() {
		long ret = Bindings.OnionPacketGetHmac(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * HMAC to verify the integrity of hop_data.
	 */
	public void set_hmac(byte[] val) {
		Bindings.OnionPacketSetHmac(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = Bindings.OnionPacketClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OnionPacket
	 */
	public OnionPacket clone() {
		long ret = Bindings.OnionPacketClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OnionPacket ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OnionPacket(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the OnionPacket.
	 */
	public long hash() {
		long ret = Bindings.OnionPacketHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two OnionPackets contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.OnionPacket b) {
		bool ret = Bindings.OnionPacketEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is OnionPacket)) return false;
		return this.eq((OnionPacket)o);
	}
	/**
	 * Serialize the OnionPacket object into a byte array which can be read by OnionPacket_read
	 */
	public byte[] write() {
		long ret = Bindings.OnionPacketWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a OnionPacket from a byte array, created by OnionPacket_write
	 */
	public static Result_OnionPacketDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.OnionPacketRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OnionPacketDecodeErrorZ ret_hu_conv = Result_OnionPacketDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
