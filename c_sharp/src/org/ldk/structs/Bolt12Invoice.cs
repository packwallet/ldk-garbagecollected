using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A `Bolt12Invoice` is a payment request, typically corresponding to an [`Offer`] or a [`Refund`].
 * 
 * An invoice may be sent in response to an [`InvoiceRequest`] in the case of an offer or sent
 * directly after scanning a refund. It includes all the information needed to pay a recipient.
 * 
 * [`Offer`]: crate::offers::offer::Offer
 * [`Refund`]: crate::offers::refund::Refund
 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
 */
public class Bolt12Invoice : CommonBase {
	internal Bolt12Invoice(object _dummy, long ptr) : base(ptr) { }
	~Bolt12Invoice() {
		if (ptr != 0) { Bindings.Bolt12InvoiceFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.Bolt12InvoiceClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Bolt12Invoice
	 */
	public Bolt12Invoice clone() {
		long ret = Bindings.Bolt12InvoiceClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt12Invoice ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt12Invoice(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The chains that may be used when paying a requested invoice.
	 * 
	 * From [`Offer::chains`]; `None` if the invoice was created in response to a [`Refund`].
	 * 
	 * [`Offer::chains`]: crate::offers::offer::Offer::chains
	 */
	public Option_CVec_ThirtyTwoBytesZZ offer_chains() {
		long ret = Bindings.Bolt12InvoiceOfferChains(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ ret_hu_conv = org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The chain that must be used when paying the invoice; selected from [`offer_chains`] if the
	 * invoice originated from an offer.
	 * 
	 * From [`InvoiceRequest::chain`] or [`Refund::chain`].
	 * 
	 * [`offer_chains`]: Self::offer_chains
	 * [`InvoiceRequest::chain`]: crate::offers::invoice_request::InvoiceRequest::chain
	 */
	public byte[] chain() {
		long ret = Bindings.Bolt12InvoiceChain(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Opaque bytes set by the originating [`Offer`].
	 * 
	 * From [`Offer::metadata`]; `None` if the invoice was created in response to a [`Refund`] or
	 * if the [`Offer`] did not set it.
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 * [`Offer::metadata`]: crate::offers::offer::Offer::metadata
	 */
	public Option_CVec_u8ZZ metadata() {
		long ret = Bindings.Bolt12InvoiceMetadata(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_u8ZZ ret_hu_conv = org.ldk.structs.Option_CVec_u8ZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The minimum amount required for a successful payment of a single item.
	 * 
	 * From [`Offer::amount`]; `None` if the invoice was created in response to a [`Refund`] or if
	 * the [`Offer`] did not set it.
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 * [`Offer::amount`]: crate::offers::offer::Offer::amount
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public Amount amount() {
		long ret = Bindings.Bolt12InvoiceAmount(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Amount ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Amount(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Features pertaining to the originating [`Offer`].
	 * 
	 * From [`Offer::offer_features`]; `None` if the invoice was created in response to a
	 * [`Refund`].
	 * 
	 * [`Offer`]: crate::offers::offer::Offer
	 * [`Offer::offer_features`]: crate::offers::offer::Offer::offer_features
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public OfferFeatures offer_features() {
		long ret = Bindings.Bolt12InvoiceOfferFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OfferFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OfferFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A complete description of the purpose of the originating offer or refund.
	 * 
	 * From [`Offer::description`] or [`Refund::description`].
	 * 
	 * [`Offer::description`]: crate::offers::offer::Offer::description
	 */
	public PrintableString description() {
		long ret = Bindings.Bolt12InvoiceDescription(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Duration since the Unix epoch when an invoice should no longer be requested.
	 * 
	 * From [`Offer::absolute_expiry`] or [`Refund::absolute_expiry`].
	 * 
	 * [`Offer::absolute_expiry`]: crate::offers::offer::Offer::absolute_expiry
	 */
	public Option_u64Z absolute_expiry() {
		long ret = Bindings.Bolt12InvoiceAbsoluteExpiry(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The issuer of the offer or refund.
	 * 
	 * From [`Offer::issuer`] or [`Refund::issuer`].
	 * 
	 * [`Offer::issuer`]: crate::offers::offer::Offer::issuer
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public PrintableString issuer() {
		long ret = Bindings.Bolt12InvoiceIssuer(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Paths to the recipient originating from publicly reachable nodes.
	 * 
	 * From [`Offer::paths`] or [`Refund::paths`].
	 * 
	 * [`Offer::paths`]: crate::offers::offer::Offer::paths
	 */
	public BlindedPath[] message_paths() {
		long ret = Bindings.Bolt12InvoiceMessagePaths(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_13_len = InternalUtils.GetArrayLength(ret);
		BlindedPath[] ret_conv_13_arr = new BlindedPath[ret_conv_13_len];
		for (int n = 0; n < ret_conv_13_len; n++) {
			long ret_conv_13 = InternalUtils.GetU64ArrayElem(ret, n);
			org.ldk.structs.BlindedPath ret_conv_13_hu_conv = null; if (ret_conv_13 < 0 || ret_conv_13 > 4096) { ret_conv_13_hu_conv = new org.ldk.structs.BlindedPath(null, ret_conv_13); }
			if (ret_conv_13_hu_conv != null) { ret_conv_13_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_13_arr[n] = ret_conv_13_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_13_arr;
	}

	/**
	 * The quantity of items supported.
	 * 
	 * From [`Offer::supported_quantity`]; `None` if the invoice was created in response to a
	 * [`Refund`].
	 * 
	 * [`Offer::supported_quantity`]: crate::offers::offer::Offer::supported_quantity
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public Quantity supported_quantity() {
		long ret = Bindings.Bolt12InvoiceSupportedQuantity(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Quantity ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Quantity(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * An unpredictable series of bytes from the payer.
	 * 
	 * From [`InvoiceRequest::payer_metadata`] or [`Refund::payer_metadata`].
	 */
	public byte[] payer_metadata() {
		long ret = Bindings.Bolt12InvoicePayerMetadata(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Features pertaining to requesting an invoice.
	 * 
	 * From [`InvoiceRequest::invoice_request_features`] or [`Refund::features`].
	 */
	public InvoiceRequestFeatures invoice_request_features() {
		long ret = Bindings.Bolt12InvoiceInvoiceRequestFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InvoiceRequestFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InvoiceRequestFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The quantity of items requested or refunded for.
	 * 
	 * From [`InvoiceRequest::quantity`] or [`Refund::quantity`].
	 */
	public Option_u64Z quantity() {
		long ret = Bindings.Bolt12InvoiceQuantity(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * A possibly transient pubkey used to sign the invoice request or to send an invoice for a
	 * refund in case there are no [`message_paths`].
	 * 
	 * [`message_paths`]: Self::message_paths
	 */
	public byte[] payer_id() {
		long ret = Bindings.Bolt12InvoicePayerId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * A payer-provided note reflected back in the invoice.
	 * 
	 * From [`InvoiceRequest::payer_note`] or [`Refund::payer_note`].
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public PrintableString payer_note() {
		long ret = Bindings.Bolt12InvoicePayerNote(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrintableString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrintableString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Duration since the Unix epoch when the invoice was created.
	 */
	public long created_at() {
		long ret = Bindings.Bolt12InvoiceCreatedAt(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Duration since [`Bolt12Invoice::created_at`] when the invoice has expired and therefore
	 * should no longer be paid.
	 */
	public long relative_expiry() {
		long ret = Bindings.Bolt12InvoiceRelativeExpiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Whether the invoice has expired.
	 */
	public bool is_expired() {
		bool ret = Bindings.Bolt12InvoiceIsExpired(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * SHA256 hash of the payment preimage that will be given in return for paying the invoice.
	 */
	public byte[] payment_hash() {
		long ret = Bindings.Bolt12InvoicePaymentHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The minimum amount required for a successful payment of the invoice.
	 */
	public long amount_msats() {
		long ret = Bindings.Bolt12InvoiceAmountMsats(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Features pertaining to paying an invoice.
	 */
	public Bolt12InvoiceFeatures invoice_features() {
		long ret = Bindings.Bolt12InvoiceInvoiceFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt12InvoiceFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt12InvoiceFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The public key corresponding to the key used to sign the invoice.
	 */
	public byte[] signing_pubkey() {
		long ret = Bindings.Bolt12InvoiceSigningPubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Signature of the invoice verified using [`Bolt12Invoice::signing_pubkey`].
	 */
	public byte[] signature() {
		long ret = Bindings.Bolt12InvoiceSignature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Hash that was used for signing the invoice.
	 */
	public byte[] signable_hash() {
		long ret = Bindings.Bolt12InvoiceSignableHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Verifies that the invoice was for a request or refund created using the given key. Returns
	 * the associated [`PaymentId`] to use when sending the payment.
	 */
	public Result_ThirtyTwoBytesNoneZ verify(org.ldk.structs.ExpandedKey key) {
		long ret = Bindings.Bolt12InvoiceVerify(this.ptr, key == null ? 0 : key.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(key);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ThirtyTwoBytesNoneZ ret_hu_conv = Result_ThirtyTwoBytesNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(key); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the Bolt12Invoice object into a byte array which can be read by Bolt12Invoice_read
	 */
	public byte[] write() {
		long ret = Bindings.Bolt12InvoiceWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
