import os
import subprocess
import re 


a = 'WMIC UserAccount Where "LocalAccount=True" Get Name'
#b = os.popen(a)
b = subprocess.check_output(a, shell=True, universal_newlines=True)
print(b)
out = b.split()
#for i in out.readline():
#	print(i)
#	print('\n')
#print (" ".join(out))
os.popen("pause")