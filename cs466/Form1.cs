using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cs466
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Username
        {
            public string user { set; get; }
            public int progress { set; get; }
        }
        private class Question
        {
            public string questionType { set; get; }
            public string questionStuff { set; get; }
            public string questionAnswer { set; get; }
            public string questionHint { set; get; }
            public string choiceOne { set; get; }
            public string choiceTwo { set; get; }
            public string choiceThree { set; get; }
        }

        static List<Question> questions = new List<Question>();
		static List<Question> multipleChoiceQuestions = new List<Question>();
		static List<Question> trueFalseQuestions = new List<Question>();
		static List<Question> imageQuestions = new List<Question> ();
        static int totalQuestions = 0;
        Username currentUser = new Username();

        private void loadQuestionFiles()
        {
			string[] files = System.IO.Directory.GetFiles(@"Resources/questions");
            foreach (string file in files)
            {
                chapterComboBox.Items.Add(file.Substring(20));
            }
            chapterComboBox.SelectedIndex = 0;
        }

        private void loadStuff(string chapter)
        {
            questions.Clear();
            multipleChoiceQuestions.Clear();
            trueFalseQuestions.Clear();
            imageQuestions.Clear();
            totalQuestions = 0;
			string loadFile = "Resources/questions/" + chapter;
            string[] text = System.IO.File.ReadAllLines(@loadFile);
            foreach (string line in text)
            {
                string[] temp = line.Split('|');
				if (temp [0].Equals ("MC")) {
					string[] choices = temp [3].Split (',');
					multipleChoiceQuestions.Add (new Question {
						questionType = temp [0],
						questionStuff = temp [1],
						questionAnswer = temp [2],
						questionHint = temp [4],
						choiceOne = choices [0],
						choiceTwo = choices [1],
						choiceThree = choices [2]
					});
				} else if (temp [0].Equals ("TF")) {
					string[] choices = temp [3].Split (',');
					trueFalseQuestions.Add (new Question {
						questionType = temp [0],
						questionStuff = temp [1],
						questionAnswer = temp [2],
						questionHint = temp [4],
						choiceOne = choices [0],
						choiceTwo = "",
						choiceThree = ""
					});
				} else {
					string[] choices = temp [3].Split (',');
					imageQuestions.Add (new Question {
						questionType = temp [0],
						questionStuff = temp [1],
						questionAnswer = temp [2],
						questionHint = temp [4],
						choiceOne = choices [0],
						choiceTwo = choices [1],
						choiceThree = choices [2]
					});
				}
                totalQuestions += 1;
            }
            treeView();
        }

        private void loadImage(int status)
        {
            if (status == 0)
            {
				pictureBox1.Image = Image.FromFile("Resources/images/wrong.jpg");
            }
            else
            {
				pictureBox1.Image = Image.FromFile("Resources/images/Albert.jpg");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login(string val)
        {
			System.IO.StreamReader reader = System.IO.File.OpenText(@"Resources/users.txt");
            JObject users = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
//<<<<<<< HEAD
            if (val == "existing") // if user clicked the Login button
            {
                try
                {
                    //FIX
                    //if (passwordTextBox.Text == users[userNameTextBox.Text]["password"].ToString())
                    if ((passwordTextBox.Text == users[userNameTextBox.Text]["password"].ToString())
                        && (userNameTextBox.Text == users[userNameTextBox.Text].ToString()))
                    {
                        currentUser.user = userNameTextBox.Text;
                        //currentUser.progress = (int)users[userNameTextBox.Text]["progress"]["3"];
                        loadStuff(chapterComboBox.Text);
                        loadProgress();
                    }
                    /*else
                    {
                        //FIX
                        //MessageBox.Show("wrong password");
                        //MessageBox.Show("Invalid username/password"); // more secure
                        //passwordTextBox.Text = "";
                        //passwordTextBox.Focus();
                        return;
                    }*/
//=======
            if (val == "existing")
            {
                try
                {
                    if (passwordTextBox.Text == users[userNameTextBox.Text]["password"].ToString())
                    {
                        currentUser.user = userNameTextBox.Text;
                        currentUser.progress = (int)users[userNameTextBox.Text]["progress"]["3"];
                        loadStuff(chapterComboBox.Text);
                        loadProgress();
                    }
                    else
                    {
                        MessageBox.Show("wrong password");
                        passwordTextBox.Text = "";
                        passwordTextBox.Focus();
                        return;
                    }
//>>>>>>> 928be964bce14c43bfd2982ac5d4d7661de63809
                }
                catch
                {
                    MessageBox.Show("Account does not exist.");
//<<<<<<< HEAD
                    //MessageBox.Show("Invalid username/password"); // more secure
                    //passwordTextBox.Text = "";
                    //passwordTextBox.Focus();
                }
            }
            else // if user clicked the Register link
            {
                //FIX
                JObject user = new JObject(
                    new JProperty(userNameTextBox.Text,
                        new JObject(
                                new JProperty("password", passwordTextBox.Text),
                                new JProperty("progress",
                                new JObject(
                                    new JProperty("3", 0),
                                    new JProperty("7", 0)
                /*JObject user = new JObject(
                    new JProperty("username", userNameTextBox.Text),
                    new JProperty("password", passwordTextBox.Text),
                    new JProperty("progress",
                            new JObject(
                                new JProperty("3", 0), // initialize to 0
                                new JProperty("7", 0) // initialize to 0*/
                            )
                    )
                )));
                try
                {
                    //FIX
                    users.Add(userNameTextBox.Text, user[userNameTextBox.Text]);
                    System.IO.File.WriteAllText(@"Resources/users.txt", users.ToString());
                    currentUser.user = userNameTextBox.Text;
                    //currentUser.progress = 0;
                    currentUser.progress = (int)users[userNameTextBox.Text]["progress"]["3"];
                    //currentUser.progress = (int)users[userNameTextBox.Text]["progress"]["7"];
                }
                catch
                {
                    //FIX
                    //MessageBox.Show("Username already exists");
                    MessageBox.Show("Invalid username/password"); // more secure
                    userNameTextBox.Text = "";
//=======
                }
            }
            else
            {
                JObject user = new JObject(
                                            new JProperty(userNameTextBox.Text,
                                                new JObject(
                                                    new JProperty("password", passwordTextBox.Text),
                                                    new JProperty("progress",
                                                    new JObject(
                                                        new JProperty("3", 0),
                                                        new JProperty("7", 0)
                                                    )))));
                try
                {
                    users.Add(userNameTextBox.Text, user[userNameTextBox.Text]);
                    System.IO.File.WriteAllText(@"Resources/users.txt", users.ToString());
                    currentUser.user = userNameTextBox.Text;
                    currentUser.progress = (int)users[userNameTextBox.Text]["progress"]["3"];
                }
                catch
                {
                    MessageBox.Show("username already exists");
//>>>>>>> 928be964bce14c43bfd2982ac5d4d7661de63809
                    userNameTextBox.Focus();
                    return;
                }
            }
//<<<<<<< HEAD
            //FIX
//=======
//>>>>>>> 928be964bce14c43bfd2982ac5d4d7661de63809
            registerLabel.Visible = false;
            passwordTextBox.Visible = false;
            userNameTextBox.Enabled = false;
            loginButton.Text = "Logout";
            passwordLabel.Visible = false;
            groupBox1.Visible = true;
            this.Size = new Size(610, 590);
        }

        private void logout()
        {
//<<<<<<< HEAD
            //FIX
//=======
//>>>>>>> 928be964bce14c43bfd2982ac5d4d7661de63809
			System.IO.StreamReader reader = System.IO.File.OpenText(@"Resources/users.txt");
            JObject users = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
            users[userNameTextBox.Text]["progress"]["3"] = currentUser.progress;
			System.IO.File.WriteAllText(@"Resources/users.txt", users.ToString());
            groupBox1.Visible = false;
            loginButton.Text = "&Login";
            userNameTextBox.Enabled = true;
            userNameTextBox.Text = "";
            userNameTextBox.Focus();
            passwordTextBox.Visible = true;
            passwordTextBox.Text = "";
            passwordLabel.Visible = true;
            registerLabel.Visible = true;
            registerLabel.Text = "Register";
            groupBox1.Visible = false;
            this.Size = new Size(610, 120);
            currentProgressBar.Value = 0;
        }

        private void loadProgress()
        {
            questions.Clear();
            if (questionTypeComboBox.Text == "True/False")
            {
                questions = new List<Question>(trueFalseQuestions);
            }
            else if (questionTypeComboBox.Text == "Multiple Choice")
            {
                questions = new List<Question>(multipleChoiceQuestions);
            }
            else
            {
                questions = new List<Question>(imageQuestions);
            }
            if (currentUser.progress > 0 && questionTypeComboBox.Text != "")
            {
                int count = 0;
                while (count < currentUser.progress)
                {
                    questions.RemoveAt(0);
                    count++;
                }
            }
			if (questions.Count > 0) {
				loadQuestion ();
			}
		}

        private void loadQuestion()
        {
            Random random = new Random();
            if (questions.Count > 0)
            {
                questionLabel.Text = questions[0].questionStuff;
                answerBox.Text = "";
                answerBox.Items.Clear();
                if (questions[0].questionType.Equals("MC"))
                {
                    int randomNumber = random.Next(0, 3);
                    switch (randomNumber)
                    {
                        case 0:
                            answerBox.Items.AddRange(new object[] {
							questions [0].questionAnswer,
							questions [0].choiceOne,
							questions [0].choiceTwo,
							questions [0].choiceThree
						});
                            break;
                        case 1:
                            answerBox.Items.AddRange(new object[] {
							questions [0].choiceOne,
							questions [0].questionAnswer,
							questions [0].choiceTwo,
							questions [0].choiceThree
						});
                            break;
                        case 2:
                            answerBox.Items.AddRange(new object[] {
							questions [0].choiceOne,
							questions [0].choiceTwo,
							questions [0].questionAnswer,
							questions [0].choiceThree
						});
                            break;
                        case 3:
                            answerBox.Items.AddRange(new object[] {
							questions [0].choiceOne,
							questions [0].choiceTwo,
							questions [0].choiceThree,
							questions [0].questionAnswer
						});
                            break;
                    }
                }
                else
                {
                    int randomNumber = random.Next(0, 100);
                    if (randomNumber % 2 == 0)
                    {
                        answerBox.Items.AddRange(new object[] { questions[0].questionAnswer, questions[0].choiceOne });
                    }
                    else
                    {
                        answerBox.Items.AddRange(new object[] { questions[0].choiceOne, questions[0].questionAnswer });
                    }
                }
            }
        }

        private void treeView()
        {
            chapterTreeView.Nodes.Clear();
            TreeNode tfNode = new TreeNode("True/False: " + trueFalseQuestions.Count().ToString());
            TreeNode mcNode = new TreeNode("Multiple Choice: " + multipleChoiceQuestions.Count.ToString());
            TreeNode imgNode = new TreeNode("Images: " + imageQuestions.Count.ToString());
            TreeNode[] array = new TreeNode[] { tfNode, mcNode, imgNode };
            TreeNode treeNode = new TreeNode("Chapter " + chapterComboBox.Text.ToString(), array);
            chapterTreeView.Nodes.Add(treeNode);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            this.Size = new Size(610, 120);
            loadQuestionFiles();
			//remove loadStuff below for release
			//loadStuff(chapterComboBox.Text);
			questionTypeComboBox.Items.AddRange (new object[] { "True/False", "Multiple Choice", "Images" });
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (registerLabel.Text == "Register")
            {
                loginButton.Text = "Register";
                registerLabel.Text = "Back";
            }
            else
            {
                loginButton.Text = "&Login";
                registerLabel.Text = "Register";
            }
        }

//<<<<<<< HEAD
        //FIX
//=======
//>>>>>>> 928be964bce14c43bfd2982ac5d4d7661de63809
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please input information");
                userNameTextBox.Focus();
                return;
            }
            else if (loginButton.Text == "&Login")
            {
                login("existing");
            }
            else if (loginButton.Text == "Logout")
            {
                logout();
            }
            else
            {
                login("create");
            }
        }

		private void chapterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProgressBar.Value = 0;
            questionLabel.Text = "";
            hintLabel.Text = "";
            questionTypeComboBox.Text = "";
            loadStuff(chapterComboBox.Text);
        }

		private void questionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hintLabel.Text = "";
			loadProgress ();
        }

        private void hintLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (questions.Count > 0)
            {
                hintLabel.Text = questions[0].questionHint;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (answerBox.SelectedItem.ToString() == questions[0].questionAnswer)
            {
                questions.RemoveAt(0);
                float percent = 100 * (((float)totalQuestions - (float)questions.Count) / (float)totalQuestions);
                currentProgressBar.Value = (int)percent;
                currentUser.progress += 1;
                loadImage(1);
                loadQuestion();
                hintLabel.Text = "";
            }
            else
            {
                loadImage(0);
                answerBox.Text = "";
            }
        }
    }
}
