Install MKL from Intel MKL website:
tar -zxvf l_mkl_2019.2.187.tgz
sudo ./install.sh
Make sure to include IA32 as well

Install g++:
sudo apt-get install g++ g++-multilib libc6-dev-i386

Build:
./mkl_build.sh
