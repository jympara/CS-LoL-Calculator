﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoL_Calculator
{
    public class Stats
    {
        public float HP;
        public float HP5;
        public float MP;
        public float MP5;
        public float AD;
        public float CritDmg;
        public float CritChance;
        public float Lethality;
        public float ArmorPen;
        public float AP;
        public float MagicPen;
        public float MagicPen_percent;
        public float CDR;
        public float Armor;
        public float MagicRes;
        public float AttackSpeed;
        public int Range;
        public int MoveSpeed;
        public int Tenacity;


        public Stats(
            float HP = 0,
            float HP5 = 0,
            float MP = 0,
            float MP5 = 0,
            float AD = 0,
            float CritDmg = 0,
            float CritChance = 0,
            float Lethality = 0,
            float ArmorPen = 0,
            float AP = 0,
            float MagicPen = 0,
            float MagicPen_percent = 0,
            float CDR = 0,
            float Armor = 0,
            float MagicRes = 0,
            float AttackSpeed = 0,
            int Range = 0,
            int MoveSpeed = 0,
            int Tenacity = 0)

        {
            this.HP = HP;
            this.HP5 = HP5;
            this.MP = MP;
            this.MP5 = MP5;
            this.AD = AD;
            this.CritDmg = CritDmg;
            this.CritChance = CritChance;
            this.Lethality = Lethality;
            this.ArmorPen = ArmorPen;
            this.AP = AP;
            this.MagicPen = MagicPen;
            this.MagicPen_percent = MagicPen_percent;
            this.CDR = CDR;
            this.Armor = Armor;
            this.MagicRes = MagicRes;
            this.AttackSpeed = AttackSpeed;
            this.Range = Range;
            this.MoveSpeed = MoveSpeed;
            this.Tenacity = Tenacity;
        }


        public static Stats operator +(Stats s1, Stats s2)
        {
            Stats s3 = new Stats
            {
                AD = s1.AD + s2.AD,
                AP = s1.AP + s2.AP,
                Armor = s1.Armor + s2.Armor,
                ArmorPen = s1.ArmorPen + s2.ArmorPen,
                AttackSpeed = s1.AttackSpeed + s2.AttackSpeed,
                CDR = s1.CDR + s2.CDR,
                CritChance = s1.CritChance + s2.CritChance,
                CritDmg = s1.CritDmg + s2.CritDmg,
                HP = s1.HP + s2.HP,
                HP5 = s1.HP5 + s2.HP5,
                Lethality = s1.Lethality + s2.Lethality,
                MagicPen = s1.MagicPen + s2.MagicPen,
                MagicPen_percent = s1.MagicPen_percent + s2.MagicPen_percent,
                MagicRes = s1.MagicRes + s2.MagicRes,
                MoveSpeed = s1.MoveSpeed + s2.MoveSpeed,
                MP = s1.MP + s2.MP,
                MP5 = s1.MP5 + s2.MP5,
                Range = s1.Range + s2.Range,
                Tenacity = s1.Tenacity + s2.Tenacity
            };
            return s3;
        }

        public static Stats operator -(Stats s1, Stats s2)
        {
            Stats s3 = new Stats
            {
                AD = s1.AD - s2.AD,
                AP = s1.AP - s2.AP,
                Armor = s1.Armor - s2.Armor,
                ArmorPen = s1.ArmorPen - s2.ArmorPen,
                AttackSpeed = s1.AttackSpeed - s2.AttackSpeed,
                CDR = s1.CDR - s2.CDR,
                CritChance = s1.CritChance - s2.CritChance,
                CritDmg = s1.CritDmg - s2.CritDmg,
                HP = s1.HP - s2.HP,
                HP5 = s1.HP5 - s2.HP5,
                Lethality = s1.Lethality - s2.Lethality,
                MagicPen = s1.MagicPen - s2.MagicPen,
                MagicPen_percent = s1.MagicPen_percent - s2.MagicPen_percent,
                MagicRes = s1.MagicRes - s2.MagicRes,
                MoveSpeed = s1.MoveSpeed - s2.MoveSpeed,
                MP = s1.MP - s2.MP,
                MP5 = s1.MP5 - s2.MP5,
                Range = s1.Range - s2.Range,
                Tenacity = s1.Tenacity - s2.Tenacity
            };
            return s3;
        }

        public static Stats operator *(Stats s1, int s2)
        {
            Stats s3 = new Stats
            {
                AD = s1.AD * s2,
                AP = s1.AP * s2,
                Armor = s1.Armor * s2,
                ArmorPen = s1.ArmorPen * s2,
                AttackSpeed = s1.AttackSpeed * s2,
                CDR = s1.CDR * s2,
                CritChance = s1.CritChance * s2,
                CritDmg = s1.CritDmg * s2,
                HP = s1.HP * s2,
                HP5 = s1.HP5 * s2,
                Lethality = s1.Lethality * s2,
                MagicPen = s1.MagicPen * s2,
                MagicPen_percent = s1.MagicPen_percent * s2,
                MagicRes = s1.MagicRes * s2,
                MoveSpeed = s1.MoveSpeed * s2,
                MP = s1.MP * s2,
                MP5 = s1.MP5 * s2,
                Range = s1.Range * s2,
                Tenacity = s1.Tenacity * s2
            };
            return s3;
        }
    }
	
    public static class Data
    {
		
    }
	
}
/*s|��IJ�����{�Z��T�Lk�Z��τms�Z�{>�Lk�b2�k��{�Z�\��s�Zʖ�n�s�Z���n�(J���q�sc�D3��{�Z�EN�ަ9����0��b?u�G��Z�����s�ZO���{�b��u+�s�RH��1�+���{�b�um߮{�Z����|�b}7}ߍs�b�L����b�_��sc0�fֽiR����{HJ���sc�uU�X�iJ�]_���Rs���q�D)s���q�HJ��
��RU(�*P�HJ��>��,kv�~msc� ���{,k�}|�{�Z�ӂn�(Jo��Ҝ�A�*��(Jߣ�
q��Zﲎ�{#!*�*jp�J�|��{'B"z*��R�}����b�>�w��Z����{cWp�{�b����{�Z��P�,k��I���Z_*�0��Z�^ɹ��R�"Wj0�B���P�HJ;��{�iRk�K��iRh
���s�b(}@��{�Z��L���Zw�Z��%)�����{�R~o?�Q�B��|���HJ����{�R��t�Lk�Z��M�Lk�Z�k:�msc�w}Ů{�Z�\��s�Zʖ�n�s�Z����3�B����sc�D3��{�Z�EN�ކ9����0��b?u�G��Z�����s�ZO�ʮs�b�u+�s�RH���{e1�+���{�b�umߍs�bo��{�{�b}'}ߍs�b�L���{�Z ���s�b�2�n��iJ����HJ����sc�u]�X�iJ�]_���Rs���q�$)s���P�IJ{��
��RU(�*P�HJ��>��,k~�~msc�
�~�{,k�i|�{�R��j�(Jo�޲��A�*��Jޣ�
q��Zﲎ���9+��{P�(J�|��{B*z*��R�}���{�b�(���c�	���{cW�r�s�b��*��,k�����Lk�>A���b��1P�c�Y!�q�c��}[�� ���"��iR?�s��,kY����,kzw}X�{c>f�
��b����P��Z��4�(J�g�'ҜIR����{�Z�+��{IJ;z;,�{�Z�ڹn���Z����iR}���{�Z{�i"Ҝ�b�W���{�Z�e����Z�5�s��Z>�n�0��R�~�Ӥ�9�o"��iR�����{LkfU�_�{c�FZ7�s�Z����ms�R�����s�Z����{�R/���ms�1�*��{IJ�����{�b�����Z9}���{�ZO� ��{�Z���3�IJ�{���iJ_��g0��A��$��s��@P�(J�+����A�� Ҝ�A�+�;��Z�������R��Q�u�B����R��=��{�b���|�{�Z{�*�Q�HR��P��9�:�����9?�s���������B�����c|��u0��Z��G�0��Zs����{�R�"r���R��޿�,kod�ZP�,k�o��0��Z�7����Zܭ9��c��/cp�iR�����{�R�s���(Ju��?,k�  �!�{iR�����(J.j���{�Z1�b�{�RN�����R�g�w��(J�g�7��B����{�Z��^�{HJ;z��{�Z���v���R���ҜiR}���{�Z{�i"Ҝ�b�W���{�R�����Z�5�c�{�Z8�l�/��R�~�Ӥ�9�o"�Ӝ�R�����LkgU�_�{c�FZ7�s�Z��ǣms�R�����{c��Ѯ{�R+����s�1�*��{IJ�����{�b�����Z9}���{�ZN� ��{c���3�iR�[���iJ_��g0��A��$��s��@P�(J�+����A�� Ҝ�A�+�;��Z����0�iR3�јu�B�����{iR��=8�{�b���|R{�*�Q�HJ��P��9�:�����9?�s���������B����8�c|��u�(J��Κ��Zs����{�R�""rҜ�Z��ֿ�c����{,k
ȼ�Q�cu'����bڋ���{�Z,����,c��WQ�c}�Y���Aw�?P�b"����{ci:��q�,cv��0��b�[�{cu�����Zo���9����0��Z�qvLk�Zq&��s�Zd/=P�iRo9���RIJ��sHJN����s�Z���Ȯ{�R<g���{�ZL6��siR/�۪���9������1J����Z��]�s�Z�����{c��=�{�Z���p��ZG��ms�Z���{�Z���=�{�Z���P��Z�����s�Z�n=�Q�HJɗ{���R����{�bۯ���{IJ2�l ֵ(J�I����9���{c�?A�0�,cuUU��iJ{���{�Zd��p��b�����Z���b�B(�p��Z��]:�{�Z������9����R�n* ��J�"��1���wP��9�Ơ��Z��'��HJ˼"n0�iR���s��Z+Q��B����{�bR~���{�Z꟠?P��R����Z[|�4��IR�ov5���b]��VP��R�ۙ;�{HJ��}�J����e1|���siR�`+�Lk�Z2q���{HJ�.���{�bEՌ��sHJ����msB
�N.Q��9�����{�R�q��Ms�RI���Mk�R~;=�HJ�9��s�R�@���sIJN����{�Z���ή{�R<g���{�ZL>��{�R��۪���9������1J����Z��]�s�Z�����{c��=�{�b�}�]P��ZG��mk�b�ʍs�Z���9�{�Z���P��Z�����s�Z�n=�Q�HJɗ{���R����{�bߧ���{IJ2�l ֵ(J�I����9���s�b�/äP�,kuUUq�iR{���{�Zd��Q��Z����iR3��b0�B*�P��b��]*��Z����0��9������R�n* 3��J�"���e1���w0��9�Ơ0��Z��'��iR˼#n0�iJ���sZ+q�3�J����{�bR����{�b�� 0��R���0�c_\�\�c�IԞ�c�Q���Z�ӫ2�c��ں0��Z{���P�bJ2:8�c�N#n�{�Z2#��0�cU���P�iRΞ���{cVF�ōs�Zx�8jq��ZD���{�Z�
�㱔�b��UԮ{�R�����{�Z'&g��{�Z��e�{�Z������R�����Zɓ5�R����{�Z� h�t�IJ�����{�Z�B�i���b�d�u�{iJʐ����c�U�ms�Z�ө���b�T���Z�6p��{�b��Ke�cJm����Z�?����Z����,c/��P�IJ���0�iR걮��s�b���zx��9۷���iJ����0��Z�;n��c���W���R�����b���M0��Z�"ֳ��Z�xa�Q��R<���Z�(���IJ�>��q�cy��D�(B��Ș���b���Ͳ�HJk?6oQ�B촣�Q��b_]&���Z1�����bU���{�Za=���{�b��	_��Z���ҜiR�y{��{iR�
n/Ҝ�R���v��iR�]u���9������(Jw[�U0�D)������A���t����<���9�'}/q�JѴ�/��9�k�p��A���n��A�>ܲ�HJ`��^�{B̨���{�RQ��[�{HJ��۴mkiR�����s�Z7g��s�Z��=��{iR�����iR����{�Z�2?�R����{�Z� j�t�IJ�����{�R�B�k���b�d�u�{�ZNڳߒ�c�U�ms�Z�ө���Z�\���Z~6p���Z��Ku�cJm����b�?��0��Z����Lk'��fP�IJ���0�iR걮��s�b���zx��A۷���iJ���Į{�R�"L#�c���Wp�iRo�'���b���M0��Z�"�2��Z�xa�q�iJ,���Z�����Z�C[Ҝcy��DQ�(J����Ҝ�b����4�iR{�6oq�B촣�P��R�.���Z1��8��bU����Za5���Z��)���Z��άq��b�}�w�{�bغ2q�{�Z����{�Z���0�,c�����c^�z�ӜiR��~/q��R���4�B7^��{(J�,$P��Z��}m�(Bꊢ�0��b���j�c��U����b�uWG4��ZWƥ��{�R���5��Z�u���{�Z��o���ZuUOv��R�߿��{�Z�m���{c&d��{�R�����{�Rﱯ�{�Rs�����Zx�ד�s�Z�8��ms�Zꢟ�,c�Z� cDms�Z
���{iR��~+�{�Z��*ٮ{�Z�as10��Z>o�q�c|՗Y0��Z�~�u�{c^-����Z�;N��{�b�ɡ�P�(J�n;��{iR��_"Ҝ�R������R������Z~O_^�{�Z�~���{�Z
ۦ��R����0��Z�yF�q�,k]e^ђ�B����0��bfu_P��b]��ˍs�"  `q�(J�=����Z�,��X΢;�����1"�����Z6q�~�c�����{,k�9u�{�Z�}��{�ba�Ѷ�{�R��󷑔�9o��.msIJ��[�{B���h��B����Ҝ!�?��4��9����A��U�!���0��9Jۡgp�D)\
Z�0�HR��c����A]6WP��1)�*�q�)?�����iR�]U��{HJ|�%��s(J���ms(Jo�N7P�(J��{���9�{�>�s�ZL���Lk�Z���Z&��/�{�Z��{��{�R���{�Rs���0��Zx�W��s�Z�8��ms�Zꢟ�,c�Z� �D�s�b�M[�{iR��~+�{�bgE�]�s�Z�as1P��Z>o�q�c|՗Y0��b�~�U�{c^-����b�?N��{�b�ɡ�P�HJ�n;��{iR��_"���Z�A����R������Z~O_^�{�Z�~���{�Zۦϕ��R����P��Z��ƛP�,k[g^���A����Q�cnu0��Z�����{�"  `�B����0��Z�,��ޢ;�����1"���R.a���c�����{,k�?���{�Z�����{�b���.�c��۽��R����0��Z�1_��b����{�b0׆범�Zo������b��t��c�`w�Q�,k_W4ֽD)�����(B�����{�Z��0��Z9v-���(J��]/��E)����ֽ� ߣ��\�e1�_�Yօ)��}��HJ�"+đ�iR���T��Z�ve�P��Z�����iR�?���{�Z�ٺ��s�Z�����IJ�����{�Z��/N�{�Z���7Ά1��?�s�Z�;��,k�R�x���c�W�u�s�bԝ��ms�Z�4�*�{�b�%��P��R���=�{c�fa�{�b����{IJ/�0��b�����{�b�k���sc����s�b{
�hJ��)��� ����1����0��R��7v�{�bu�0��Z4v�yZ�~�{�{�Z��:.��iJw��}��Z��=ݭ{!�H"0��A/����{�R��?��Z�V=���bG}ES��9�����b��V�{�ZW�?��{�Z���0��R��lh���Zw��\��RS]�ލs�Aj��j�{B���Սs(J�?��� jʨ���HR��}���HJH��m0��9_��Lk�9�/nP��9��	[3�Jmi�u�D1����HJ��Y]��A�ҍ{B����0�`��*��D1�_�Ҝ�9���q�HRG�g3��A���V��A��f�P�c�Yb�{iR�?{�ms�Z���
�{c�T�tP�iR�����{�Z��/O�{�Z�l�7Ά1��?ms�Z2;��,k�R�z���c�W�u�s�bԝ��s�Z�4��{�b�%��P��Z���=�{c�fa�{�Z��{B*� ��b�����{�Z�˽��{c����s�bk��{iR��	��� ����1����0��R��7v�s�Zm:P��Z4v����Z�^�{��Z�y.&�B������Z��-��{a" H��A/����s�b��o�s�b�+,�Ҝ�ZG�o�ҜIJ��Ч�iR����{�ZWJ?��{�Z��ͮ{�Z�(�`0��b�����{�bG���P��b�Eo0��R<����{�bةq�ֽJ�P��b|��&0��br���T��R����0�(J2�/H3��9O�{���Z�^_��iR��Ѻ�s�Z���~��ZǷ���{J�"�����b�ӭs�Z��h��R�c�0�iJ���/��R���0�IJ�^�+P�iJL���0��Z]P�v0��R;U��P��Z�]W�siRܫ��q��Z��[3��RWM_�Ʀ9���O0��R����ms�R��hq��bw}WLk�b#k.��{�Z_3�ms�Z���,�s�ZJ9���{�bh�k!��Z�����{�Zk�.�0��R���K�{c��yߍs�Z�����s�b:ϟ0�c�5uű�(J����{�9�����{�b��s�b�f	��{�Z������b7�g��Z����msiJ����P�iR<��٭s(J�{�n�Z��WT���A����P�iR��o���iR��w��R^�O�0��A˞Ͼ�R�wQw��9K��u��ZF�U��iR��s�(J���8��AՑU�΃B�9�3��9x����IR�]���!����,k�AN��ޮ{(JtwU�,k�9�H�4�$)�ѿ�/��A��_��a��:Kls(J���s��9/g?�iRK^��u�D1�ѭ�Lk�9+q$cmsiRVl�s�iRZJ�6�iR����{HR�^�;��Aj�����Z}X��P�iR?߻���Z�]��MkiR�#.P��Z��[3��RWM_�Ʀ9���O1��R���Ǝs�Z���xq��bw}WLk�b#k.��{�Z_1��s�Z�ɒ6�s�ZJ9��{�bh�z#�{�Z����{�Zk�.�0��R���K�s�b����s�b�׉�s�b:ϟ0�c�5uű�(J����{�9�����{�b��s�b�f��{�Z����P�c�e�R�3��{(J������R�mߙ��Z�{H�p�iR9�^�{�b'����Z~�j8��A��u�t�B~�O߱�IR��M�u��R�wQW��AK���R��_߮{�Z���oP�(J���7�(J����q�c�����{�Z�n��{�Z���
��� �����{B���P�IJ®�)Ҝ�R��}��  ��λq�(J���aq�iR���R���3��Zo��0��Z����4�(J����P��Z�����Z��{��{�ZÚ�2��b�?����R�����{�Z��z�Lk�Z<�����b�E}���Z���z�{�Z��0��bߕe�c_T�ƕ�(J�����s�b��.둔�Z]Ems�Z�h:�Lk�Z�( -�{�Z��߿�sc5]o��{�Z�빯�{�Z�,�k��Z�o�<ms�R��&��{�Rl�o��{�b�ٷ�s�bd�S�Mk�bc
O��iJ�~��Ӝ'J���;msHJ$2�{iR��α�{�Z۬��T��Z��E��HJ�j�-��Z��]Q�{HJ�a���{(J�Ϙ��{�9���/��9���P��9h����Bo����{�R[�w�{�Z^���{'J��"�msHJ0$�c��{HJ�8x��{�A6�O�|�1�����(Jpuu/�J��3�e1�߳�P��9�����e)ؗ�Ҝ$)�����Ze1�ʈ�c)k��.�iR����J�	�u�HRi�f!Q�D1����sJ�:���9{���$)|��0�(J����iRV���P�J��0��b�r�Ҝ(J����{iR��|��s�R������Z�g}���Z���j��Z[�����Z�g�c_T����(J�����s�b��.�q��ZYE�s�Z�h>�Lk�Z�( -�{�Z��ߟ�sc=]g�ms�R	��
�{�Z�,�k��Z�g�<ms�R��6��{iR�o��{�Z����s�bd��s�b{�o��siR�|��Ҝ(J���;�siR�$���{iR��α�{�Z۬��u��Z��E��(J�j�-��IJ����0�(B�c�����Z��^��{B��1(��Z�U�N0�HJΧ�q�B�H�0�(JӪ��s�Z�{��B��"��s(J0&�
,k��ms(J�(`	�{HJf;����9׃��u�B�z�T�B�����c�_���Z������Z5�����Z��Y]q�$!�ʌ���1�d�6;�9%���x�IJ���o�{�bz�"��,k�ӵ_�{,k
z�:��Z����Bۯ:�0�iRI*m��{�Z*3�{�ZƏ����b{u�y��R�����{�Z�z���{�Z4n=�s�b1���Z]vw|�c�W�QP��Z5o���Z�����LkUU&�,k���q�iR����P�iJ����{�Z����Mk�b/&鸮{�Z�4{�s�Z�����s�b�#���{cu�5��c6����{�R�z2ms(JȪ)�{�b$�03�IJ�����s�R��Ӥ��Z�c�:0��b�],�HJ�����iR�n��{�Z��DP��A����(J��.pp��Z���֒�B+o����(J�_O�{(J��:�{�bq�]7Ls�1��+j�HJ���Lk�Z��U�ms�Z�k7?0�iRz��(J�����sHJ���18�j�8�(J\EVW�{�9Pϼ��HJ�uy�4��A����� �����Ze1��J�!����c(Ju�7�1���q��A_�]�1��N+q��9v�?}��A+�3�{B��q��e1$Ϻ�4�HJu�����9����HJ���4�HJ�����iR��"P�(Jξ�K�{�R�r-��{�Z��=sms�Z!;���b]Wu\�cWW�Q0��Z5����Z�����Lk]U&�,k���q/�iJ����P�iJ��ｮ{�Z����msc5�y��{�Z�6{�s�Z����s�b�!���{cw�5��c6����{�R�z�T�(J��u��Z�_�N�{�Z�s���s�Z�����Z�n.��{�b��+�{iR���>�HJ�����Z��fP��A����iR��.p��Z��2��{�Z:Ic�s�b|X^I�s�b���s�Z⛯��{e1��+h���9����{�Z�����s�Z?�6�{B`����B�����{iR������:�j�}�iR\E^W�{iRZ����{�b�u[Սs�b�z���Zv{��{�bW�5~�iR}_�q��Zu1>�X�e1��ѓ��9
� P�iR��?"��Z����sc!
6�0��ba����,c��ޤ��IJ������A����q�iR�κꑔc�w�~�{c^��{�Z
3ᩖ�HJ?�P
*/