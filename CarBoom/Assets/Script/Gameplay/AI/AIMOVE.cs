

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections.Generic;
using Assets.Script.Gameplay.AI;
namespace Assets.Script.Gameplay.AI
{
    public class AIMOVE : MonoBehaviour
    {

        static float v = 5f;
        private int[,] map;
        private bool[,] visited;
        private int[,] distance;
        private Stack<Combine> s;
        private int x;
        private int z;
        private int MAX;
        private int ax;
        private int az;
        Combine target;
        public Transform targ;
        private System.Random ran;
        void Start()
        {
            s = new Stack<Combine>();
            target = new Combine((int)(targ.localPosition.x + 1) / 2,(int) (targ.localPosition.z + 1) / 2);
            this.MAX = 16;
            map = new int[MAX, MAX];
            for (int i = 1; i < MAX - 1; i++)
                for (int j = 1; j < MAX - 1; j++)
                    map[i, j] = 0;

       

            this.map[4, 0] = 2;
            this.map[4, 2] = 2;
            this.x = -1;
            this.z = 0;
        }
        
        void Update()
        {
            ran = new System.Random();
            Vector3 bar = transform.position;
            target = new Combine((int)(targ.localPosition.x ) / 2, (int)(targ.localPosition.z ) / 2);
            float hor = Input.GetAxis("Horizontal"), ver = Input.GetAxis("Vertical");
            float m = bar.x + 1;
            double n = 0;
            double k = 0;
            if ((int)((bar.x + n) / 2 - 0.4) == (int)((bar.x + n) / 2 + 0.4))
                ax = (int)((bar.x + k) / 2);
            else
            {
                az = (int)((bar.z + n) / 2);
                if (map[(int)((bar.x + n) / 2 - 0.4), az + 1] == 1 || map[(int)((bar.x + n) / 2 - 0.4), az - 1] == 1)
                    ax = (int)((bar.x + k) / 2 - 0.4);
                else
                    ax = (int)((bar.x + k) / 2 + 0.4);
            }
            if ((int)((bar.z + n) / 2 - 0.4) == (int)((bar.z + n) / 2 + 0.4))
                az = (int)((bar.z + k) / 2);
            else
            {
                ax = (int)((bar.x + n) / 2);
                if (map[(int)((bar.z + n) / 2 - 0.4), ax + 1] == 1 || map[(int)((bar.z + n) / 2 - 0.4), ax - 1] == 1)
                    az = (int)((bar.z + k) / 2 - 0.4);
                else
                    az = (int)((bar.z + k) / 2 + 0.4);
            }
            if (ax < 0)
                ax = 0;
            if (az < 0)
                az = 0;
            bfs();
      //      Debug.Log("distance " + distance[target.getA(), target.getB()]);
            if (distance[target.getA(), target.getB()] <= 20)
            {
                attackMove();
//                Debug.Log("Attack");
            }
            else
            {
                randomMove();
//                Debug.Log("Random");
            }
        }
        void bfs()
        {
            Queue<Combine> q = new Queue<Combine>();
            visited = new bool[MAX, MAX];
            distance = new int[MAX, MAX];
            for (int i = 0; i < MAX; i++)
                for (int j = 0; j < MAX; j++)
                {
                    visited[i, j] = false;
                    distance[i, j] = 99;
                }
            Combine u = new Combine(ax, az);
            q.Enqueue(u);
            distance[u.getA(), u.getB()] = 0;
            visited[u.getA(), u.getB()] = true;
            while (q.Count != 0)
            {
                u = q.Dequeue();
                if (u.getA() + 1 < MAX && map[u.getA() + 1, u.getB()] <= 0 && visited[u.getA() + 1, u.getB()] == false)
                {
                    distance[u.getA() + 1, u.getB()] = distance[u.getA(), u.getB()] + 1;
                    Combine c = new Combine(u.getA() + 1, u.getB());
                    visited[u.getA() + 1, u.getB()] = true;
                    q.Enqueue(c);
                }
                if (u.getA() - 1 >= 0 && map[u.getA() - 1, u.getB()] <= 0 && visited[u.getA() - 1, u.getB()] == false)
                {
                    distance[u.getA() - 1, u.getB()] = distance[u.getA(), u.getB()] + 1;
                    Combine c = new Combine(u.getA() - 1, u.getB());
                    visited[u.getA() - 1, u.getB()] = true;
                    q.Enqueue(c);
                }
                if (u.getB() + 1 < MAX && map[u.getA(), u.getB() + 1] <= 0 && visited[u.getA(), u.getB() + 1] == false)
                {
                    distance[u.getA(), u.getB() + 1] = distance[u.getA(), u.getB()] + 1;
                    Combine c = new Combine(u.getA(), u.getB() + 1);
                    visited[u.getA(), u.getB() + 1] = true;
                    q.Enqueue(c);

                }
                if (u.getB() - 1 >= 0 && map[u.getA(), u.getB() - 1] <= 0 && visited[u.getA(), u.getB() - 1] == false)
                {
                    distance[u.getA(), u.getB() - 1] = distance[u.getA(), u.getB()] + 1;
                    Combine c = new Combine(u.getA(), u.getB() - 1);
                    visited[u.getA(), u.getB() - 1] = true;
                    q.Enqueue(c);
                }
            }
            if (this.distance[target.getA(), target.getB()] <= 15)
            {
                this.s.Clear();
                int t = distance[target.getA(), target.getB()];
                s.Push(target);
                Combine m = new Combine(target.getA(), target.getB());
                t--;
                while (t > 0)
                {
                    if (m.getA() + 1 < MAX && distance[m.getA() + 1, m.getB()] == t)
                    {
                        m = new Combine(m.getA() + 1, m.getB());
                        s.Push(m);
                        //            Debug.Log(t + " " + 1);
                    }
                    else if (m.getA() - 1 >= 0 && distance[m.getA() - 1, m.getB()] == t)
                    {
                        m = new Combine(m.getA() - 1, m.getB());
                        s.Push(m);
                        //           Debug.Log(t + " " + 2);
                    }
                    else if (m.getB() + 1 < MAX && distance[m.getA(), m.getB() + 1] == t)
                    {
                        m = new Combine(m.getA(), m.getB() + 1);
                        s.Push(m);
                        //            Debug.Log(t + " " + 3);
                    }
                    else if (m.getB() - 1 > 0 && distance[m.getA(), m.getB() - 1] == t)
                    {
                        m = new Combine(m.getA(), m.getB() - 1);
                        s.Push(m);
                        //          Debug.Log(t + " " + 4);
                    }
                    //     Debug.Log(t);
                    t--;
                }
            }
            /*
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
                    Debug.Log( i + " " + j + "     " +  distance[i, j]);
                }
            }
            */
        }

        void attackMove()
        {
//            Debug.Log("stack " + s.Count);

            if (s.Count > 0)
            {
                x = s.Peek().getA() - ax;
                //      Debug.Log(x);
                z = s.Peek().getB() - az;
                //       Debug.Log(z);
                if (x == 1)
                    transform.Translate(Time.deltaTime * v, 0f, 0f);
                else if (x == -1)
                    transform.Translate(Time.deltaTime * -v, 0f, 0f);
                else if (z == 1)
                    transform.Translate(0f, 0f, Time.deltaTime * v);
                else if (z == -1)
                    transform.Translate(0f, 0f, Time.deltaTime * -v);
//                Debug.Log("x " + x + " z " + z);
            }
        }
        void randomMove()
        {
            if (x == 1)
            {
                transform.Translate(Time.deltaTime * v, 0f, 0f);
                if (ax >= 9)
                    x = -1;
                else if (map[ax + 1, az] == 2 || (map[ax + 2, az] == 2 && ax < this.MAX - 2))
                {
                    if (ax > 0 && map[ax - 1, az] == 0)
                    {
                        System.Console.WriteLine("ahihi");
                        x = -1;
                    }
                    else if (az > 0 && map[ax, az - 1] == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                    else if (az < this.MAX - 1 && map[ax, az + 1] == 0)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az > 1 && map[ax, az - 1] == 0 && az < 10 && map[ax, az + 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                    else if (r == 1)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az < 9 && map[ax, az + 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az > 1 && map[ax, az - 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                }

                else if (map[ax + 1, az] == 1 || ax >= 9)
                {
                    if (az < 10 && map[ax - 1, az + 1] == 0)
                    {
                        int r = ran.Next(0, 10);
                        if (r == 0)
                        {
                            x = 0;
                            z = 1;
                        }
                    }
                    else if (az > 1 && map[ax, az - 1] == 0)
                    {
                        int r = ran.Next(0, 3);
                        if (r == 0)
                        {
                            x = 0;
                            z = -1;
                        }
                    }
                    else if (az > 1 && map[ax, az - 1] == 0 && az < 10 && map[ax, az + 1] == 0)
                    {
                        int r = ran.Next(0, 10);
                        if (r == 0)
                        {
                            x = 0;
                            z = -1;
                        }
                        else if (r == 1)
                        {
                            x = 0;
                            z = 1;
                        }
                    }
                    else
                    {
                        x = -1;
                    }
                }
            }
            else if (x == -1)
            {
                transform.Translate(Time.deltaTime * v * (-1), 0f, 0f);
                if (ax <= 0)
                    x = 1;
                else if (ax > 0 && (map[ax - 1, az] == 2) || (ax > 1 && (map[ax - 2, az] == 2)))
                {
                    if (ax < this.MAX - 1 && map[ax + 1, az] == 0)
                        x = 1;
                    else if (az > 0 && map[ax, az - 1] == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                    else if (az < this.MAX - 1 && map[ax, az + 1] == 0)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az > 1 && map[ax, az - 1] == 0 && az < 10 && map[ax, az + 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                    else if (r == 1)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az < 10 && map[ax, az + 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (az > 1 && map[ax, az - 1] == 0 && ax >= 0 && ax <= 9)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                }

                else if (map[ax - 1, az] == 1 || ax <= 0)
                {
                    if (az < 10 && map[ax - 1, az + 1] == 0)
                    {
                        int r = ran.Next(0, 10);
                        if (r == 0)
                        {
                            x = 0;
                            z = 1;
                        }
                    }
                    else if (az > 0 && map[ax, az - 1] == 0)
                    {
                        int r = ran.Next(0, 10);
                        if (r == 0)
                        {
                            x = 0;
                            z = -1;
                        }
                    }
                    else if (az > 0 && map[ax, az - 1] == 0 && az < 10 && map[ax, az + 1] == 0)
                    {
                        int r = ran.Next(0, 10);
                        if (r == 0)
                        {
                            x = 0;
                            z = -1;
                        }
                        else if (r == 1)
                        {
                            x = 0;
                            z = 1;
                        }
                    }
                    else
                    {
                        x = 1;
                    }
                }

            }
            if (z == 1)
            {
                transform.Translate(0f, 0f, Time.deltaTime * v);
                if (az >= 9)
                    z = -1;
                else if (map[ax + 1, az] == 2 || (map[ax + 2, az] == 2 && ax < this.MAX - 2))
                {
                    if (az > 0 && map[az - 1, ax] == 0)
                        z = -1;
                    else if (az > 0 && map[ax, az - 1] == 0)
                    {
                        x = 0;
                        z = -1;
                    }
                    else if (az < this.MAX && map[ax, az + 1] == 0)
                    {
                        x = 0;
                        z = 1;
                    }
                }
                else if (map[ax, az + 1] == 2 || (map[ax, az + 2] == 2 && az < this.MAX - 2))
                {
                    if (az > 0)
                        z = -1;
                    else if (ax > 0 && map[ax - 1, az] == 0)
                    {
                        x = -1;
                        z = 0;
                    }
                    else if (ax < this.MAX - 1 && map[ax + 1, az] == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                }
                else if (ax >= 1 && map[ax - 1, az] == 0 && ax < 9 && map[ax + 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                    else if (r == 1)
                    {
                        x = -1;
                        z = 0;
                    }
                }
                else if (ax < 9 && map[ax + 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                }
                else if (ax >= 1 && map[ax - 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = -1;
                        z = 0;
                    }
                }

                else if (map[ax, az + 1] == 1 || az == 9)
                {
                    if (ax < 9 && map[ax + 1, az] == 0)
                    {
                        int r = ran.Next(0, 3);
                        if (r == 0)
                        {
                            x = 1;
                            z = 0;
                        }
                    }
                    else if (ax > 0 && map[ax - 1, az] == 0)
                    {
                        int r = ran.Next(0, 6);
                        if (r == 0)
                        {
                            x = -1;
                            z = 0;
                        }
                    }
                    else if (ax > 0 && map[ax - 1, az] == 0 && ax < 9 && map[ax + 1, az] == 0)
                    {
                        int r = ran.Next(0, 6);
                        if (r == 0)
                        {
                            x = -1;
                            z = 0;
                        }
                        else if (r == 1)
                        {
                            x = 1;
                            z = 0;
                        }
                    }
                    else
                    {
                        z = -1;
                    }
                }
            }
            else if (z == -1)
            {
                transform.Translate(0f, 0f, Time.deltaTime * v * (-1));
                if (az <= 0)
                    z = 1;
                else if ((az > 0 && map[ax, az - 1] == 2 || (az > 1 && (map[ax, az - 2] == 2))))
                {
                    if (az < this.MAX - 1 && map[ax, az + 1] == 0)
                        z = 1;
                    else if (ax > 0 && map[ax - 1, az] == 0)
                    {
                        x = -1;
                        z = 0;
                    }
                    else if (ax < this.MAX - 1 && map[ax + 1, az] == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                }
                else if (ax >= 1 && map[ax - 1, az] == 0 && ax < 9 && map[ax + 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                    else if (r == 1)
                    {
                        x = -1;
                        z = 0;
                    }
                }
                else if (ax < 9 && map[ax + 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = 1;
                        z = 0;
                    }
                }
                else if (ax >= 1 && map[ax - 1, az] == 0 && az >= 0 && az < 10)
                {
                    int r = ran.Next(0, 10);
                    if (r == 0)
                    {
                        x = -1;
                        z = 0;
                    }
                }

                else if ((az < MAX - 1 && map[ax, az + 1] == 1) || az == 0)
                {
                    if (ax < 9 && map[ax + 1, az] == 0)
                    {
                        int r = ran.Next(0, 6);
                        if (r == 0)
                        {
                            x = 1;
                            z = 0;
                        }
                    }
                    if (ax > 0 && map[ax - 1, az] == 0)
                    {
                        int r = ran.Next(0, 6);
                        if (r == 0)
                        {
                            x = -1;
                            z = 0;
                        }
                    }
                    if (ax > 0 && map[ax - 1, az] == 0 && ax < 9 && map[ax + 1, az] == 0)
                    {
                        int r = ran.Next(0, 6);
                        if (r == 0)
                        {
                            x = -1;
                            z = 0;
                        }
                        else if (r == 1)
                        {
                            x = 1;
                            z = 0;
                        }
                    }
                    else
                    {
                        z = 1;
                    }
                }
            }
        }
    }
}