# 整体框架
1、导入资源   
2、根据需求划分模块，决定创建项目步骤   
3、创建unity资源   
4、给动画编写代码。  
5、给动画创建事件  
6、调试代码
7、调试项目
# 目录结构
Project视图
> Assest  
>> Scene  
>> Rescourses 
>>> WW4_Effects_Sub
>>>> Effect
>>>>> Soldier
>>>>>> FrostArcher
>>>>>>> FrostArcher_effect
>>>>>>>> Materials  
>>>>>>>> shader
>>>> Fbx
>>>>> Armies
>>>>>> 0_Texture
>> Script  
## 代码结构
>> Script 
>>> Controller
>>>> SoldierController.cs 士兵控制器
>>>>> SelfAttackMethod 攻击方法
>>>>> ShowAttack 展示攻击动画
>>>>> SetSoldierHpValue 设置士兵的血量
>>>>> SetLive 设置是否存活
>>>>> AttackEvent 攻击事件
>>>>> RunEvent 奔跑事件
>>>>> IdleEvent 空闲事件  
>>>>> JsonToModel 解析json
>>> Utils
>>>> 
>>> Pojos  
>>>> SoldierModel.cs 展示的每个滑块对象  
>>> Utils 第三方工具包  
## 层级视图

MainScene
> BackGroundImage
>> Soldier
## 流程图
![Image text](https://github.com/89trillion-liuhao/myTest/blob/main/1.png)
