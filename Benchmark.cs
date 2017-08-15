using BenchmarkDotNet.Attributes;
using benchmarkef.Insert;
using benchmarkef.Select;

namespace benchmarkef
{
    public class Benchmark
    {
        private EfInsert _efInsert;
        private DapperInsert _dapperInsert;
        private EfSelect _efSelect;
        private DapperSelect _dapperSelect;
        private EfSelectWithFilter _efSelectWithFilter;
        private DapperSelectWithFilter _dapperSelectWithFilter;

        public Benchmark(){

            _efInsert = new EfInsert(); 
            _dapperInsert = new DapperInsert();   

            _efSelect = new EfSelect();
            _dapperSelect = new DapperSelect();

            _efSelectWithFilter = new EfSelectWithFilter();
            _dapperSelectWithFilter = new DapperSelectWithFilter();
        }

        [Benchmark]
        public void DapperInsert0() => _dapperInsert.Run();

        [Benchmark]
        public void EfInsert0() => _efInsert.Run();

        [Benchmark]
        public void DapperSelect0() => _dapperInsert.Run();

        [Benchmark]
        public void EfSelect0() => _efInsert.Run();

        [Benchmark]
        public void DapperSelectWithFilter0() => _dapperInsert.Run();

        [Benchmark]
        public void EfSelectWithFilter0() => _efInsert.Run();
    }
}