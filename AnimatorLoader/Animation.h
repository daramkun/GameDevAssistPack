#pragma once

#include <windows.h>

enum ObjType
{
	OT_IMAGE = 0,
	OT_SOUND,
	OT_DAMAGEPOINT,
	OT_ASSULTPOINT,
	OT_ETC,
};

struct AnimationUsingObject
{
	int index;
	int x, y;
	int width, height;
	float angle;
};

struct AnimationFrame
{
	AnimationUsingObject *objs;
	int objlength;
	int anchor_x, anchor_y;
};

struct AnimationFrameMode
{
	AnimationFrame *frms;
	int frmlength;
	int screen_width, screen_height;
	LPSTR name;
};

struct AnimationObject
{
	LPSTR name;
	LPSTR path;
	unsigned char *data;
	unsigned char tc_a, tc_r, tc_g, tc_b;
	ObjType type;
};

class Animation
{
private:
	AnimationFrameMode *modes;
	int modelength;
	AnimationObject *objs;
	int objlength;

	int speed;

public:
	Animation(void);
	~Animation(void);

	bool Load(LPCSTR);

	AnimationFrameMode* GetFrameMode(int index);
	AnimationFrameMode* GetFrameMode(LPSTR name);
};