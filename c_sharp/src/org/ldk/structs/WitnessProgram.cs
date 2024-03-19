using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class WitnessProgram : CommonBase {
	/** The witness program bytes themselves */
	public readonly byte[] program;
	/** The witness version */
	public readonly WitnessVersion version;

	internal WitnessProgram(object _dummy, long ptr) : base(ptr) {
		this.program = InternalUtils.DecodeUint8Array(Bindings.WitnessProgramGetProgram(ptr));
		this.version = new WitnessVersion(Bindings.WitnessProgramGetVersion(ptr));
	}
	static private long check_args(byte[] program, WitnessVersion version) {
		if (program.Length < 2 || program.Length > 40) throw new ArgumentException();
		if (version.getVal() == 0 && program.Length != 20 && program.Length != 32) throw new ArgumentException();
		return InternalUtils.EncodeUint8Array(program);
	}
	public WitnessProgram(byte[] program, WitnessVersion version) :
		this(null, Bindings.WitnessProgramNew(version.getVal(), check_args(program, version))) {}

	~WitnessProgram() {
		if (ptr != 0) { Bindings.WitnessProgramFree(ptr); }
	}
}} } }
