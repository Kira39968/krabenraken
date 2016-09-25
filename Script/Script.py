import os
import subprocess
import re 


a = 'net user'
b = subprocess.check_output(a, shell=True, universal_newlines=True)
print(b)
out = b.split()
#for i in out.readline():
#	print(i)
#	print('\n')
#print (" ".join(out))
os.popen("pause")