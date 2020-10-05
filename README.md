# UniFontMaker
A font maker for Unitale/CYF (and Minecraft resource pack). WIP.  
Unitale/CYF 字体制作器  

`master` 分支是给 Unitale 字体用的，可以编译使用  
`remake` 分支目前在重写，加入对 MC 资源包的支持  

`CharacterTemplate` 文件夹下面是常用的字符模板  

## 示例 Example
示例 Mod 在 ChineseExampleMod 文件夹里  
![示例截图](images/unitale_chinese_1.png)

## 使用说明 How to use
### 制作字体
1.点击 `Add` 从 txt 文件添加里字符，你可以在 `CharacterTemplate` 里找到常用汉字
2.选择字体名称（`Font Name`），通常 `uidialog` 为旁白字体，`monster` 为怪物对话框字体，其他自行探索（有时间补充）
3.行间距（`Line Spacing`）一般不需要改
4.点击 `Change Font` 选择一个字体，建议的字体如下
```
宋体 四号 宽 1000 高 1400 行间距 30  
Zpix 四号 宽 1000 高 1400 行间距 30  
方正像素 小二 宽 1000 高 1400 行间距 30  
```
5.点击保存（`Save`）

### 安装字体
复制到`[MOD名称]\Sprites\UI\Fonts\`下覆盖即可  
通常来说不建议复制到`Default`目录下，会导致所有 Mod 加载速度变慢（因为默认加载中文字体）  
至于在对话中如何使用自定义名称的字体，参考 Unitale/CYF 的文档  