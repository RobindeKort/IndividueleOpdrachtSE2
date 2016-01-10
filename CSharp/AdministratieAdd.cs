using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public partial class Administratie
    {
        // Insert een nieuwe 'Comment' in de database
        public void AddComment(Comment comment)
        {
            // Nothing to check
            db.InsertComment(comment);
        }

        // Controleert of een 'User' met dezelfde 'loginName' al bestaat
        // als deze 'User' al bestaat, wordt de nieuwe 'User' niet
        // in de database ge-insert
        public bool AddUser(User user)
        {
            foreach (User u in users)
            {
                if (user.LoginName == u.LoginName)
                {
                    return false;
                }
            }
            db.InsertNormalUser(user);
            return true;
        }

        // Insert een nieuwe 'Discussion' in de database
        public void AddDiscussion(Discussion discussion)
        {
            db.InsertDiscussion(discussion);
        }
    }
}