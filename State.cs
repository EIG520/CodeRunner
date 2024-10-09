class State {
    public InternalData vars;
    public int cur_line;

    public State() {
        vars = new InternalData();
        cur_line = 0;
    }
}