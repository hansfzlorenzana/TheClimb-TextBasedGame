/******************************************************************************

                   @Author Lorenzana, Hans Friedrich Zoren N.
                             Course: CC6 | CITCS 3B 
                              IDE: Visual Basic C#

*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Lorenzana_TextBasedGame
{
    class Lorenzana_TextBasedGame
    {
        static void Main()
        {
            gameStart();
        }



        public static void gameStart()
        {
            string playerName;

            Console.WriteLine(@"
             _____ _   _  _____   _____  _     ________  _________ 
            |_   _| | | ||  ___| /  __ \| |   |_   _|  \/  || ___ \
              | | | |_| || |__   | /  \/| |     | | | .  . || |_/ /
              | | |  _  ||  __|  | |    | |     | | | |\/| || ___ \
              | | | | | || |___  | \__/\| |_____| |_| |  | || |_/ /
              \_/ \_| |_/\____/   \____/\_____/\___/\_|  |_/\____/ 
  
             ------- Based from JACK AND THE BEANSTALK ------------
                                                                    ");

            Console.WriteLine(@"'Wake up! or else you'll gonna be caught!'.
You tried to look for where the voice is coming from but you don't see anybody. 
Suddenly, you hear big stomping noises from not afar. 'STOMP! STOMP! STOMP!'
'Please wake up! Someone is coming to eat you.' Said the same voice.
You can hear the stomping coming closer and closer. As the door slowly cracks open...

You see a light temporarily blinding you. 
'Finally, you're awake! Were you having a nightmare?That's what you get from oversleeping.'
You find yourself in a room still blinded by the ray of light coming from the sun,
peaking through your opened window curtains. You see a figure of a lady beside your window.
'Go and wash your face already. Go to the market and sell our only cow. We'll be eating dust and perish if you don't.'
Said by the lady. The lady is pretty, around her 40s and is wearing dirty and rugged clothes.

'Who are you?' you shouted to the lady.
'I'm your mother, silly. Did the nightmare gave you an amnesia?'
You thought to yourself. Perhaps. You briefly tried to remember your name.");

            Console.Write("\nMy name is <please enter a nickname>... ");
            playerName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine("\n'Ah yes, that's right. I am {0}' you muttered", playerName);
            Console.WriteLine();
            firstScene();
        }

        public static void firstScene()
        {
            string choice;
            Console.WriteLine("------------- DILEMMA EVERY MORNING ----------------");
            Console.WriteLine(@"'What are you talking about? Get out from your bed already. I'll go to the kitchen now.' 
said your mother. You are still sleepy, confused and curious on who or where the stomping noises in your dream is 
coming from. What will you do?");

            Console.WriteLine();
            Console.WriteLine("\t1. Get out of bed.");
            Console.WriteLine("\t2. Go back to sleep.");
            Console.WriteLine();
            Console.Write("You choose: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "out of bed")
            {
                Console.WriteLine(@"You got out of your bed and rushed to the bathroom to wash your face.
After washing your face, you hurriedly put on your market clothes and reached out for the cow rope.
You went outside your house and saw your only cow. You leashed the cow and departed. 
'I'm going mother!' you bid to your mother.");

                Console.ReadLine();
                secondScene();
            }
            else if (choice == "2" || choice == "sleep")
            {
                Console.WriteLine(@"You went back to sleep hoping you will dream again.
You became so lazy and hopeless. Your only cow died because you won't feed it.
Soon after, your mother became ill. Because you are poor, food is scarce.
Your mother died after a few weeks. You are left alone. Infected by your mother, you became sick too.
After a few weeks, you also died.");

                Console.WriteLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("Invalid command...");
                Console.WriteLine("Press ENTER to try again.");
                Console.ReadLine();
                firstScene();
            }
        }

        public static void secondScene()
        {
            string choice;
            Console.WriteLine("------------- BEANS, GOLD, OR BOTH? ----------------");
            Console.WriteLine(@"On your way to the market to sell your cow, you met a man who wanted to buy the cow. 
'What will you give me in return for my cow?' you asked. The man answered, 'I will give you these five magic beans!.
Will you trade me your cow in exchange for my five magic beans?'");

            Console.WriteLine();
            Console.WriteLine("\t1. Accept the offer.");
            Console.WriteLine("\t2. Decline the offer.");
            Console.WriteLine("\t3. Steal the magic beans.");
            Console.WriteLine();
            Console.Write("You choose: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "accept")
            {
                Console.WriteLine(@"Curious about the mysterious beans, you accepted the offer.
You took the magic beans and gave the man the cow. You are so eager to get home. 
'My mother will be so proud!' you thought to yourself.");

                Console.WriteLine();
                Console.ReadLine();
                thirdScene();
            }
            else if (choice == "2" || choice == "decline")
            {
                Console.WriteLine(@"Afraid you're mother will get furious at you for exchanging the cow
with some beans, you declined the offer. 'Sorry, we badly need money. My mother will be angry.' You said to the man.
Pulling your cow, you went to the market leaving the man behind. You sold your cow for 5 GOLD pieces.

You went home. Your mother was very happy. 'We are rich!' she said.
Days and weeks and months went by, the 5 GOLD pieces turned into only 1 copper coin.

You became very poor again.");

                Console.WriteLine();
                gameOver();
            }
            else if (choice == "3" || choice == "steal")
            {
                Console.WriteLine(@"Afraid your mother will become furious if you sell your cow with some beans but 
at the same time curious on what these beans are, you suddenly thought of something ingenious and...evil. 
You snatched the magic beans from the man, pulled your cow and ran leaving the man behind.

As you are on your way to the market to continue to sell the cow, bandits suddenly appeared. They forcefully got your cow,
stripped you of everything, and left you behind naked. The only thing the bandits didn't steal is the magic beans.");

                Console.WriteLine();
                Console.ReadLine();
                thirdScene();
            }
            else
            {
                Console.WriteLine("Invalid command...");
                Console.WriteLine("Press ENTER to try again.");
                Console.ReadLine();
                secondScene();
            }
        }

        public static void thirdScene()
        {
            string choice;
            Console.WriteLine("------------- THE BEANSTALK AND THE GIANT ----------------");
            Console.WriteLine(@"You went back home. You told your mother what happened and she became so angry.
'I have these magic beans though' showing the beans to your mother.

'You fool! Our cow is gone and now you give me some beans?!' She threw the beans out of the window.
You were very sad and went to sleep without dinner.

The next day, you woke up in the morning and looked out of the window.
You saw that a huge beanstalk had grown outside from where the magic beans were thrown
Again curious, you climbed up the beanstalk and reached a kingdom at the peak.
There lived a giant and his wife. You went inside the palace and found the giant's wife in the kitchen.
The wife is human like and nothing like what the ugly face giant statue you saw outside the kingdom.
You then approached the wife and asked, 'Could you please give me something to eat? I am so hungry!
The kind wife gave you bread and some milk. As you were eating, you noticed the sacks of gold coins shining
coming from a big room.

You hear giant footsteps noises from outside 'STOMP! STOMP! STOMP!'. You peeked outside from the small slit on
the wall. You see the giant coming closer and closer. The giant was very big and looked very fearsome.

You are terrified. What will you do?");

            Console.WriteLine();
            Console.WriteLine("\t1. Nothing. You were so afraid to move.");
            Console.WriteLine("\t2. Hide inside the kitchen cabinet.");
            Console.WriteLine("\t3. Try to flee.");
            Console.WriteLine();
            Console.Write("You choose: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "nothing")
            {
                Console.WriteLine(@"As soon as you saw the giant, you were petrified in fear.
You couldn't move. The giant is now in front of the door and cried, 'Fee-fi-fo-fum. I smell blood of a man.
Be he alive, or be he dead, I'll grind his bones to make my bread!'

The giant went inside and saw you frozen in fear and with traces of having been eating. The giant grabbed you.
And the last thing you saw as you are being squeezed and ripped apart is the wife, crying and couldn't do
a thing. You died.");

                Console.WriteLine();
                gameOver();
            }
            else if (choice == "2" || choice == "hide")
            {
                Console.WriteLine(@"As soon as you saw the giant, you rushed straight through the cabinet nearby
and hid inside. The giant is now in front of the door and cried, 'Fee-fi-fo-fum. I smell blood of a man.
Be he alive, or be he dead, I'll grind his bones to make my bread!'

The giant went inside. 'There is no one here but me!' The wife said to the giant. 'Here, I've prepared some food.'
So, the giant ate his food and then went to his room. He took out his sacks of gold coins, counted them and kept them aside.
Then the giant went to sleep. You waited til night came. ");

                Console.WriteLine();
                Console.ReadLine();
                fourthScene();
            }
            else if (choice == "3" || choice == "flee")
            {
                Console.WriteLine(@"As soon as you saw the giant, you slid through a human size hole in the wall and
found yourself outside the back of the palace. You heard the door open and heard the giant screaming inside but
in inaudible sounds. You sneaked to the front, hid in the palace garden and waited for night to come.");

                Console.WriteLine();
                Console.ReadLine();
                fourthScene();
            }
            else
            {
                Console.WriteLine("Invalid command...");
                Console.WriteLine("Press ENTER to try again.");
                Console.ReadLine();
                thirdScene();
            }
        }

        public static void fourthScene()
        {
            string choice;
            Console.WriteLine("------------- CLIMBING. AGAIN! ----------------");
            Console.WriteLine(@"You crept out of your hiding place, sneakingly went inside the palace, and
took one sack of gold coins. Then, you hurriedly climbed down the beanstalk. 

At home, you gave the coins to your mother. Your mother was very happy and they lived well for sometime.

After some time, you climbed the beanstalk and went to the giant's house again. Once again, you asked
the giant's wife for food, but as you were eating, the giant returned. This time, suddenly opening the door.
You leapt up in fright, still unseen by the giant and in a flash, hid under the bed. 

The giant cried, 'Fee-fi-fo-fum. I smell blood of a man. Be he alive, or be he dead, 
I'll grind his bones to make my bread!' The wife said, 'There is no one here but me!'

Convinced. The giant proceeded to this room. There, he took out a hen. He shouted, 'Lay!' and the hen
laid a golden egg. When the giant fell asleep, you took the hen and climbed down the beanstalk. Your
mother again was very happy with you. 

The hen is laying one golden egg every day. But you and your mother wanted more. Your mother had an idea.
'Why don't we cut open the hen? Maybe we'll find more golden eggs inside!' You're curious but hesitant.
What will you do?
");

            Console.WriteLine();
            Console.WriteLine("\t1. Do not cut the hen open.");
            Console.WriteLine("\t2. Cut the hen open.");
            Console.WriteLine("\t3. The hen sometime died.");
            Console.WriteLine();
            Console.Write("You choose: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "do not cut")
            {
                Console.WriteLine(@"'We can't be sure if there will be more golden eggs inside' you told your mother.
You and your mother agreed not to cut the hen open as you can't take the risk of losing it all.
You lived a prosperous life for quite some time with your mother. The hen continued to lay eggs for months
until one day, the hen won't lay eggs anymore. Still, you did not let greed get into you.
You let the hen live and made it as your pet.");

                Console.WriteLine();
                Console.ReadLine();
                finalScene();
            }
            else if (choice == "2" || choice == "cut")
            {
                Console.WriteLine(@"'What a nice idea mother!' you said in excitement. You then went to the kitchen,
got the knife, and went to the hen. You killed the hen open in hope for more riches. Unfortunately, you
did not find any eggs inside. In addition, all the remaining golden eggs turned into rotten eggs. 

You thought of going back to the beanstalk but surprised that the beanstalk has rotten as well!
Seems like if the hen is purposely killed, the magic in the beans will be gone. After some time, your
mother became very ill. Your mother later died of sickness. You were infected and also died.");

                Console.WriteLine();
                gameOver();
            }
            else if (choice == "3" || choice == "hen died")
            {
                Console.WriteLine(@"'We can't be sure if there will be more golden eggs inside' you told your mother.
You and your mother agreed not to cut the hen open as you can't take the risk of losing it all.
You lived a prosperous life for quite some time with your mother. The hen continued to lay eggs for months
until one day, the hen seems to becoming weaker and won't lay eggs anymore. Still, you did not let greed 
get into you. You let the hen live and made it a pet. Unfortunately, the hen died after a few months.");

                Console.WriteLine();
                Console.ReadLine();
                finalScene();
            }
            else
            {
                Console.WriteLine("Invalid command...");
                Console.WriteLine("Press ENTER to try again.");
                Console.ReadLine();
                fourthScene();
            }
        }

        public static void finalScene()
        {
            string choice;
            Console.WriteLine("------------- FRIENDSHIP OR BETRAYAL! ----------------");
            Console.WriteLine(@"Afraid that you will lose everything, you once again climbed the beanstalk
and went to the giant's castle. For the third time, you met the kind wife and asked for some food.
Once again, the giant's wife gave you bread and milk. But while eating, the giant came home. You
hid again inside the cabinet holding your breath.

'Fee-fi-fo-fum. I smell blood of a man. Be he alive, or be he dead, 
I'll grind his bones to make my bread!' The wife said, 'There is no one here but me!'

The giant went to the cabinet. And reached something on top of the cabinet then went back to his chair.

You saw from the crevice of the cabinet the giant holding a magical harp that could play
beautiful songs. While the giant slept, you took the harp and was about to leave. Suddenly, the magic
harp cried, 'Help Master!' Someone is stealing me!'. The giant woke up and saw you with the harp.
Furious, he ran after you. But you were too fast for him. 

You ran down the beanstalk and reached home. The giant is trying to follow you down but he is too slow. 
What will you do?");

            Console.WriteLine();
            Console.WriteLine("\t1. Get the axe and chop the beanstalk!");
            Console.WriteLine("\t2. Get the knife and chop the beanstalk.");
            Console.WriteLine("\t3. Dig the magic beans.");
            Console.WriteLine("\t4. Kneel and ask for forgiveness.");
            Console.WriteLine();
            Console.Write("You choose: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "axe")
            {
                Console.WriteLine(@"You quickly ran inside your house and fetched an AXE.
While your mother is on the look out for the giant. You began to chop the beanstalk.

'Quick! The giant is coming.' The beanstalk began collapsing and losing its balance from its roots.
The giant, being so heavy and still high up the beanstalk, fell along with the beanstalk.
Because of the fall damage, the giant died. Also, you have never seen the giant's wife again.");

                Console.WriteLine();
                Console.ReadLine();
                youWin();
            }
            else if (choice == "2" || choice == "knife")
            {
                Console.WriteLine(@"You quickly ran inside your house and fetched a KNIFE.
While your mother is on the look out for the giant. You began to chop the beanstalk.

'Quick! The giant is coming.' The giant is almost closing in. While you can't even make a cut 
out of the beanstalk from the knife. You panicked. Sweating. 

As the giant is coming closer to the ground. He jumped. Your mother was crushed on the giant's
impact leading to her instant death while you are petrified in fear. Shaking. 

'I finally got you, you little rat!' The giant squashed you with his big heavy hands!
You died instantly.");

                Console.WriteLine();
                gameOver();
            }
            else if (choice == "3" || choice == "dig")
            {
                Console.WriteLine(@"Distressed by the thought of a giant coming after you. You panicked.
You went straight to the roots of the beanstalk and tried DIGGING and digging. Your mother saw you and
started digging also in hope of finding the magic beans and pulling it out making the beanstalk rot.

'Quick! The giant is coming.' The giant is almost closing in. While you and your mother can't even
dig a hole with your bare hands. The magic beans is no where in sight. You both panicked. Sweating. 

As the giant is coming closer to the ground. He jumped. You and your mother looked up and saw the giant
jumping down. You and your mother were crushed on impact.You both died.");

                Console.WriteLine();
                gameOver();

            }
            else if (choice == "4" || choice == "kneel")
            {
                Console.WriteLine(@"You quickly ran inside your house and saw your mother.
'Mother. Mother. The giant is coming. We have sinned a lot and now we are about to perish. I'm scared.'
you said to your mother. 

'Child. Please give that harp back to where it belongs. I don't want to live in prosperity because
of greed and theft and by using other people. I've already given back the gold pieces left and 
the hen, dead or alive, to the giant's wife. She was kind to accept. I don't want this kind of
living anymore, child.' cried your mother. 

You realized what your mother has said and agreed. You and your mother went outside the house.
Looked up and saw the giant going down.

'The giant is coming. Whatever will happen, this is the right path to take, child' she smiled

The giant looked down and saw you and your mother kneeling down, surrendering the harp.
The giant carefully went down the beanstalk. Slightly furious. But the giant's wife came
into rescue and talked everything to him about what the mother had done.

'Please forgive us! We have wronged.' you and your mother said in unison.

The giant smiled. 'I accept. Raise up your heads. Sorry about the things I have said
about tearing you apart. I can see deep inside your regrets.' 

The giant's wife also smiled. 'I have been testing you, child. I'm happy you finally
realized your mistakes. Here, take this bread and milk as token of our friendship.
You can visit us anytime on our palace.'

The beanstalk remained. It bore fruits(not beans) as time passed by. The giant said you can harvest
it and think of it as a sign of prosperity between you and your mother.");

                Console.WriteLine();
                Console.ReadLine();
                youWin();
            }
            else
            {
                Console.WriteLine("Invalid command...");
                Console.WriteLine("Press ENTER to try again.");
                Console.ReadLine();
                finalScene();
            }
        }

        public static void youWin()
        {
            Console.WriteLine("You and your mother became very rich and lived happily ever after.");
            Console.WriteLine(@"
        ,----,                                                                  
      ,/   .`|       ,--,                                     ,--.              
    ,`   .'  :     ,--.'|    ,---,.            ,---,.       ,--.'|    ,---,     
  ;    ;     /  ,--,  | :  ,'  .' |          ,'  .' |   ,--,:  : |  .'  .' `\   
.'___,/    ,',---.'|  : ',---.'   |        ,---.'   |,`--.'`|  ' :,---.'     \  
|    :     | |   | : _' ||   |   .'        |   |   .'|   :  :  | ||   |  .`\  | 
;    |.';  ; :   : |.'  |:   :  |-,        :   :  |-,:   |   \ | ::   : |  '  | 
`----'  |  | |   ' '  ; ::   |  ;/|        :   |  ;/||   : '  '; ||   ' '  ;  : 
    '   :  ; '   |  .'. ||   :   .'        |   :   .''   ' ;.    ;'   | ;  .  | 
    |   |  ' |   | :  | '|   |  |-,        |   |  |-,|   | | \   ||   | :  |  ' 
    '   :  | '   : |  : ;'   :  ;/|        '   :  ;/|'   : |  ; .''   : | /  ;  
    ;   |.'  |   | '  ,/ |   |    \        |   |    \|   | '`--'  |   | '` ,/   
    '---'    ;   : ;--'  |   :   .'        |   :   .''   : |      ;   :  .'     
             |   ,/      |   | ,'          |   | ,'  ;   |.'      |   ,.'       
             '---'       `----'            `----'    '---'        '---'         
");

            restart();
        }

        public static void gameOver()
        {
            Console.WriteLine(@"
                 *             )            (     
 (       (     (  `         ( /(            )\ )  
 )\ )    )\    )\))(  (     )\())(   (  (  (()/(  
(()/( ((((_)( ((_)()\ )\   ((_)\ )\  )\ )\  /(_)) 
 /(_))_)\ _ )\(_()((_|(_)    ((_|(_)((_|(_)(_))   
(_)) __(_)_\(_)  \/  | __|  / _ \ \ / /| __| _ \  
  | (_ |/ _ \ | |\/| | _|  | (_) \ V / | _||   /  
   \___/_/ \_\|_|  |_|___|  \___/ \_/  |___|_|_\  
                                                  
");
            restart();
        }

        public static void restart()
        {
            string choice;

            Console.Write("\nPlay again? <y/n>: ");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes" || choice == "y")
            {
                gameStart();
            }
            else
            {
                Console.WriteLine("\nThanks for playing! :)");
            }
        }
    }
}
