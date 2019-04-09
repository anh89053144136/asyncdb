﻿using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class TransactionsForPostprocessing
    {
        public Guid Id { get; set; }

        public bool IsProcessed { get; set; }

        public Guid DocumentId { get; set; }

        public int TransactionType { get; set; }

        public int DocflowType { get; set; }

        public DateTime CreateDate { get; set; }
    }
}