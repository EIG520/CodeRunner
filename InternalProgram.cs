class InternalProgram {
    List<Line> lines;

    public InternalProgram() {
        this.lines = new List<Line>();
    }

    public InternalProgram(int size) {
        this.lines = new List<Line>(size);
    }

    public void addLine(Line line) {
        lines.Add(line);
    }

    public void run() {
        State state = new State();

        while (step(state)) {}
    }

    public bool step(State state) {
        Line line = lines[state.cur_line];

        if (line != null) {

            try {
                line.cmd(state);
            } catch(Exception e) {
                return false;
            }
        }

        state.cur_line++;

        if (state.cur_line >= lines.Count) {
            return false;
        }

        return true;
    }
}

