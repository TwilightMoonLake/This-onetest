# 牧场模拟项目
                            游戏管理模块
                                ↓
        数据管理   动物管理模块  UI管理模块 玩家管理模块  ？？模块  ？
          ↓            ↓               ↓      ↓
    音乐 动物 天气等   ↓               ↓      ↓
               行为控制 天气判断       ↓      ↓
							                         ↓      ↓
					                	启动模块   ？     ↓ 
                           
代码结构：待补充
## 1.天气系统
### 插件的使用：
Unistrom天气控制插件的应用，内置管理板块和大量的天气系统，高效快速的帮助建立牧场的外部环境，本次应用的该项目的天气为晴天，多云，雨天，暴雨，雪，雾，红色极光与蓝色极光，完成昼夜时间的更迭与天气的变换。

## 2.动物管理模块
### 设计思路：
1.创建Data模板，以此创建动物基本数据，包括生命值，好感度，移动速度，成长值等int或float型数据。
2.创建CharacteStat脚本，用来记录与调用数据，同时完成数值的计算
3.创建Animal Manage动物管理脚本，实现动物行为功能：判断顺序为：判断动物类型→判断动物年龄→判断动物行为
三个部分写三个枚举，分别用来作为记录各部分的标准
动物行为分为Clear天气下的正常行为，以及非Claer下各种特殊天气下的行为。其中，动物拥有部分的共同行为，也拥有该物种的特殊行为。并且，在特殊天气下，某种动物会产生有别于其他动物的特殊行为。
动物的各种行为分别写成方法，在判断语句判定动物种类，年龄，天气后调用。
调用有关动物的CharacterState的两部分数据
`CharacterState characterState;`
`characterState.characterWeatherData.{isClear,isCloudy...}`
`characterState.templateAnimalData.{speed,maxHealth...}`
调用动物行为的方法
`private AnimalBehavior animalBehavior;`
`animalBehavior.{AnimalMove,AnimalRun,AnimalSleep...}`
待补充

### 2


***
***
# 备注
## 
脚本文件位于Assets/Script文件夹中，因为不确认结构的合理性，暂时没有写动物行为的方法
游戏内场景搭建和素材的导入，以及动画状态机的设置,在结构验证合理后开始搭建。
