#include "Animation.h"
#include <iostream>
#include <fstream>
using namespace std;

Animation::Animation(void)
{
	modes = NULL;
	objs = NULL;
}

Animation::~Animation(void)
{
	if(objs != NULL)
	{
		for(int i = 0; i < objlength; i++)
		{
			delete [] objs[i].name;
			delete [] objs[i].path;
			delete [] objs[i].data;
		}
	}

	if(modes != NULL)
	{
		for(int i = 0; i < modelength; i++)
		{
			for(int j = 0; j < modes[i].frmlength; j++)
			{
				delete [] modes[i].frms[j].objs;
			}
			delete [] modes[i].frms;
			delete [] modes[i].name;
		}
		delete [] modes;
	}
}

bool Animation::Load(LPCSTR file)
{
	ifstream is;
	is.open(file, ifstream::binary);
	if(is.fail()) { MessageBox(NULL, "asdf", "asdf", NULL); return false; }

	char buffer = NULL;
	is.read(&buffer, 1);
	if(buffer != 'A') return false;
	is.read(&buffer, 1);
	if(buffer != 'N') return false;
	is.read(&buffer, 1);

	is.read((char*)&speed, 4);

	modelength = NULL;
	is.read((char*)&modelength, 4);
	modes = new AnimationFrameMode[modelength];
	/*----------------------*/cout << "ÇÁ·¹ÀÓ¸ðµå °¹¼ö : " << modelength << endl;
	for(int i = 0; i < modelength; i++)
	{
		char namelength = NULL;
		is.read(&namelength, 1);
		if(namelength != 0)
		{
			modes[i].name = new char[namelength + 1];
			is.read(modes[i].name, namelength);
			modes[i].name[namelength] = NULL;
			/*----------------------*/cout << "ÇÁ·¹ÀÓ¸ðµå ÀÌ¸§ : " << modes[i].name << endl;
		}

		is.read((char*)&modes[i].screen_width, 4);
		/*----------------------*/cout << "½ºÅ©¸° °¡·Î : " << modes[i].screen_width << endl;
		is.read((char*)&modes[i].screen_height, 4);
		/*----------------------*/cout << "½ºÅ©¸° ¼¼·Î : " << modes[i].screen_height << endl;

		modes[i].frmlength = NULL;
		is.read((char*)&modes[i].frmlength, 4);
		modes[i].frms = new AnimationFrame[modes[i].frmlength];
		/*----------------------*/cout << "ÇÁ·¹ÀÓ °¹¼ö : " << modes[i].frmlength << endl;
		for(int j = 0; j < modes[i].frmlength; j++)
		{
			is.read((char*)&modes[i].frms[j].anchor_x, 4);
			/*----------------------*/cout << "¾ÞÄ¿ X : " << modes[i].frms[j].anchor_x << endl;
			is.read((char*)&modes[i].frms[j].anchor_y, 4);
			/*----------------------*/cout << "¾ÞÄ¿ Y : " << modes[i].frms[j].anchor_y << endl;

			modes[i].frms[j].objlength = NULL;
			is.read((char*)&modes[i].frms[j].objlength, 4);
			modes[i].frms[j].objs = new AnimationUsingObject[modes[i].frms[j].objlength];
			/*----------------------*/cout << "»ç¿ë °´Ã¼ °¹¼ö : " << modes[i].frms[j].objlength << endl;
			for(int k = 0; k < modes[i].frms[j].objlength; k++)
			{
				is.read((char*)&modes[i].frms[j].objs[k].index, 4);
				/*----------------------*/cout << "»ç¿ë °´Ã¼ ÀÎµ¦½º : " << modes[i].frms[j].objs[k].index << endl;
				is.read((char*)&modes[i].frms[j].objs[k].x, 4);
				/*----------------------*/cout << "»ç¿ë °´Ã¼ X : " << modes[i].frms[j].objs[k].x << endl;
				is.read((char*)&modes[i].frms[j].objs[k].y, 4);
				/*----------------------*/cout << "»ç¿ë °´Ã¼ Y : " << modes[i].frms[j].objs[k].y << endl;
				is.read((char*)&modes[i].frms[j].objs[k].width, 4);
				/*----------------------*/cout << "»ç¿ë °´Ã¼ °¡·Î : " << modes[i].frms[j].objs[k].width << endl;
				is.read((char*)&modes[i].frms[j].objs[k].height, 4);
				/*----------------------*/cout << "»ç¿ë °´Ã¼ ¼¼·Î : " << modes[i].frms[j].objs[k].height << endl;
			}
		}
	}

	objlength = NULL;
	is.read((char*)&objlength, 4);
	objs = new AnimationObject[objlength];
	/*----------------------*/cout << "°´Ã¼ °¹¼ö : " << objlength << endl;
	for(int i = 0; i < objlength; i++)
	{
		int namelength = NULL;
		is.read((char*)&namelength, 1);
		if(namelength != 0)
		{
			objs[i].name = new char[namelength + 1];
			is.read(objs[i].name, namelength);
			objs[i].name[namelength] = NULL;
			/*----------------------*/cout << "°´Ã¼ ÀÌ¸§ : " << objs[i].name << endl;
		}

		int pathlength = NULL;
		is.read((char*)&pathlength, 1);
		if(pathlength != 0)
		{
			objs[i].path = new char[pathlength + 1];
			is.read(objs[i].path, pathlength);
			objs[i].path[pathlength] = NULL;
			/*----------------------*/cout << "°´Ã¼ °æ·Î : " << objs[i].path << endl;
		}

		int type = NULL;
		is.read((char*)&type, 1);
		objs[i].type = (ObjType)type;
		/*----------------------*/cout << "°´Ã¼ Å¸ÀÔ : " << objs[i].type << endl;
		is.read((char*)&objs[i].tc_a, 1);
		/*----------------------*/cout << "°´Ã¼ A : " << objs[i].tc_a << endl;
		is.read((char*)&objs[i].tc_r, 1);
		/*----------------------*/cout << "°´Ã¼ R : " << objs[i].tc_r << endl;
		is.read((char*)&objs[i].tc_g, 1);
		/*----------------------*/cout << "°´Ã¼ G : " << objs[i].tc_g << endl;
		is.read((char*)&objs[i].tc_b, 1);
		/*----------------------*/cout << "°´Ã¼ B : " << objs[i].tc_b << endl;

		int datalength = NULL;
		is.read((char*)&datalength, 4);
		if(datalength != 0)
		{
			objs[i].data = new unsigned char[datalength];
			is.read((char*)objs[i].data, datalength);
		}
	}

	is.close();

	return true;
}

AnimationFrameMode* Animation::GetFrameMode(int index)
{
	return &modes[index];
}

AnimationFrameMode* Animation::GetFrameMode(LPSTR name)
{
	for(int i = 0; i < modelength; i++)
	{
		if(strcmp(name, modes[i].name) == 0)
			return &modes[i];
	}

	return NULL;
}