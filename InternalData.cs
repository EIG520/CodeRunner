public class InternalData {
    Dictionary<string, InternalDataType> vars;

    public InternalData() {
        vars = new Dictionary<string, InternalDataType>();
    }

    public void Set(string name, InternalDataType value) {
        vars[name] = value;
    }

    public InternalDataType Get(string name) {
        return vars[name];
    }
}

public interface InternalDataType {}

public class InternalString : InternalDataType {
    public string value;

    public InternalString(string value) {
        this.value = value;
    }

    public override string ToString() {
        return value;
    }
}

public class InternalInt : InternalDataType {
    public int value;

    public InternalInt(int value) {
        this.value = value;
    }

    public override string ToString() {
        return value.ToString();
    }
}
