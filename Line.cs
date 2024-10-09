class Line {
    public string code;

    public Func<State, int> cmd;

    public Line() {code = ""; cmd = state => 0;}
    
    public Line(string code_, Func<State, int> cmd_) {
        code = code_;
        cmd = cmd_;
    }
}

// Defaults

class InitStr : Line {
    public InitStr(string vname) {
        code = $"string {vname};";
        cmd = state => {state.vars.Set(vname, null); return 0; };
    }

    public InitStr(string vname, string vval) {
        code = $"string {vname} = {vval};";
        cmd = state => {state.vars.Set(vname, new InternalString(vval)); return 0; };
    }
}

class SetStr : Line {
    public SetStr(string vname, string vval) {
        code = $"{vname} = {vval};";
        cmd = state => {state.vars.Set(vname, new InternalString(vval)); return 0; };
    }
}

class WriteVar : Line {
    public WriteVar(string vname) {
        code = $"Console.WriteLine({vname})";
        cmd = state => {Console.WriteLine(state.vars.Get(vname)); return 0; };
    }
}

class WriteStr : Line {
    public WriteStr(string vstr) {
        code = $"Console.WriteLine({vstr})";
        cmd = state => {Console.WriteLine(vstr); return 0; }
    }
}