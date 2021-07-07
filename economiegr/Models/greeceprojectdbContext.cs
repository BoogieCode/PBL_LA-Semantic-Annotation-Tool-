using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace economiegr.Models
{
    public partial class greeceprojectdbContext : DbContext
    {
        public greeceprojectdbContext()
        {
        }

        public greeceprojectdbContext(DbContextOptions<greeceprojectdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<CoursePhase> CoursePhases { get; set; }
        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<LaMethod> LaMethods { get; set; }
        public virtual DbSet<PblStep> PblSteps { get; set; }
        public virtual DbSet<RelLatoolLam> RelLatoolLams { get; set; }
        public virtual DbSet<RelStepActTool> RelStepActTools { get; set; }
        public virtual DbSet<RelToolDatum> RelToolData { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<Relations3> Relations3s { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<StepSkill> StepSkills { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-F56NIVV;Database=greeceprojectdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Idactivity)
                    .HasName("PK_activity_idactivity");

                entity.ToTable("activity", "testultimcurs");

                entity.Property(e => e.Idactivity).HasColumnName("idactivity");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(45)
                    .HasColumnName("activity_name");
            });

            modelBuilder.Entity<CoursePhase>(entity =>
            {
                entity.HasKey(e => e.IdcoursePhase)
                    .HasName("PK_course_phase_idcourse_phase");

                entity.ToTable("course_phase", "testultimcurs");

                entity.Property(e => e.IdcoursePhase)
                    .ValueGeneratedNever()
                    .HasColumnName("idcourse_phase");

                entity.Property(e => e.CphaseName)
                    .HasMaxLength(45)
                    .HasColumnName("cphase_name");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasKey(e => e.Iddata)
                    .HasName("PK_data_iddata");

                entity.ToTable("data", "testultimcurs");

                entity.Property(e => e.Iddata)
                    .ValueGeneratedNever()
                    .HasColumnName("iddata");

                entity.Property(e => e.DataName)
                    .HasMaxLength(500)
                    .HasColumnName("data_name");
            });

            modelBuilder.Entity<LaMethod>(entity =>
            {
                entity.HasKey(e => e.IdlaMethod)
                    .HasName("PK_la_method_idla_method");

                entity.ToTable("la_method", "testultimcurs");

                entity.Property(e => e.IdlaMethod)
                    .ValueGeneratedNever()
                    .HasColumnName("idla_method");

                entity.Property(e => e.LamethodName)
                    .HasMaxLength(500)
                    .HasColumnName("lamethod_name");
            });

            modelBuilder.Entity<PblStep>(entity =>
            {
                entity.HasKey(e => e.IdpblStep)
                    .HasName("PK_pbl_step_idpbl_step");

                entity.ToTable("pbl_step", "testultimcurs");

                entity.Property(e => e.IdpblStep).HasColumnName("idpbl_step");

                entity.Property(e => e.StepName)
                    .HasMaxLength(45)
                    .HasColumnName("step_name");
            });

            modelBuilder.Entity<RelLatoolLam>(entity =>
            {
                entity.HasKey(e => new { e.Techid, e.Lamid })
                    .HasName("PK_rel_latool_lam_techid");

                entity.ToTable("rel_latool_lam", "testultimcurs");

                entity.HasIndex(e => e.Lamid, "lam_id_idx_lam");

                entity.HasIndex(e => e.Techid, "tech_id_idx_tec");

                entity.Property(e => e.Techid).HasColumnName("techid");

                entity.Property(e => e.Lamid).HasColumnName("lamid");

                entity.Property(e => e.Idrel4).HasColumnName("idrel4");

                entity.HasOne(d => d.Lam)
                    .WithMany(p => p.RelLatoolLams)
                    .HasForeignKey(d => d.Lamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_latool_lam$lam_id_idx_lam");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.RelLatoolLams)
                    .HasForeignKey(d => d.Techid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_latool_lam$tech_id_idx_tec");
            });

            modelBuilder.Entity<RelStepActTool>(entity =>
            {
                entity.HasKey(e => new { e.Actid, e.Stepid, e.Techid })
                    .HasName("PK_rel_step_act_tool_actid");

                entity.ToTable("rel_step_act_tool", "testultimcurs");

                entity.HasIndex(e => e.Actid, "act_id_idx");

                entity.HasIndex(e => e.Actid, "actid");

                entity.HasIndex(e => e.Stepid, "step_id_idx");

                entity.HasIndex(e => e.Techid, "tech_id_idx");

                entity.Property(e => e.Actid).HasColumnName("actid");

                entity.Property(e => e.Stepid).HasColumnName("stepid");

                entity.Property(e => e.Techid).HasColumnName("techid");

                entity.Property(e => e.Idrel1).HasColumnName("idrel1");

                entity.HasOne(d => d.Act)
                    .WithMany(p => p.RelStepActTools)
                    .HasForeignKey(d => d.Actid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_step_act_tool$act_id_idx");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.RelStepActTools)
                    .HasForeignKey(d => d.Stepid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_step_act_tool$step_id_idx");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.RelStepActTools)
                    .HasForeignKey(d => d.Techid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_step_act_tool$tech_id_idx");
            });

            modelBuilder.Entity<RelToolDatum>(entity =>
            {
                entity.HasKey(e => new { e.Dataid, e.Techid })
                    .HasName("PK_rel_tool_data_dataid");

                entity.ToTable("rel_tool_data", "testultimcurs");

                entity.HasIndex(e => e.Techid, "tech_id_idx5");

                entity.Property(e => e.Dataid).HasColumnName("dataid");

                entity.Property(e => e.Techid).HasColumnName("techid");

                entity.Property(e => e.Idrel2).HasColumnName("idrel2");

                entity.HasOne(d => d.Data)
                    .WithMany(p => p.RelToolData)
                    .HasForeignKey(d => d.Dataid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_tool_data$data_id_idx5");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.RelToolData)
                    .HasForeignKey(d => d.Techid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rel_tool_data$tech_id_idx5");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.HasKey(e => new { e.Actid, e.Stepid, e.Dataid, e.Techid, e.Lamid })
                    .HasName("PK_relations_actid");

                entity.ToTable("relations", "testultimcurs");

                entity.HasIndex(e => e.Actid, "act_id_idx");

                entity.HasIndex(e => e.Dataid, "data_id_idx");

                entity.HasIndex(e => e.Lamid, "lam_id_idx");

                entity.HasIndex(e => e.Stepid, "step_id_idx");

                entity.HasIndex(e => e.Techid, "tech_id_idx");

                entity.Property(e => e.Actid).HasColumnName("actid");

                entity.Property(e => e.Stepid).HasColumnName("stepid");

                entity.Property(e => e.Dataid).HasColumnName("dataid");

                entity.Property(e => e.Techid).HasColumnName("techid");

                entity.Property(e => e.Lamid).HasColumnName("lamid");

                entity.Property(e => e.Idrelation).HasColumnName("idrelation");

                entity.HasOne(d => d.Act)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.Actid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("relations$act_id");

                entity.HasOne(d => d.Data)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.Dataid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("relations$data_id");

                entity.HasOne(d => d.Lam)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.Lamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("relations$lam_id");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.Stepid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("relations$step_id");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.Techid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("relations$tech_id");
            });

            modelBuilder.Entity<Relations3>(entity =>
            {
                entity.HasKey(e => new { e.Actid, e.Stepid, e.Techid, e.Lamid })
                    .HasName("PK_relations3_actid");

                entity.ToTable("relations3", "testultimcurs");

                entity.HasIndex(e => e.Actid, "act_id_idx");

                entity.HasIndex(e => e.Lamid, "lam_id_idx");

                entity.HasIndex(e => e.Stepid, "step_id_idx");

                entity.HasIndex(e => e.Techid, "tech_id_idx");

                entity.Property(e => e.Actid).HasColumnName("actid");

                entity.Property(e => e.Stepid).HasColumnName("stepid");

                entity.Property(e => e.Techid).HasColumnName("techid");

                entity.Property(e => e.Lamid).HasColumnName("lamid");

                entity.Property(e => e.Idrelation).HasColumnName("idrelation");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.Idskills)
                    .HasName("PK_skills_idskills");

                entity.ToTable("skills", "testultimcurs");

                entity.Property(e => e.Idskills)
                    .ValueGeneratedNever()
                    .HasColumnName("idskills");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(45)
                    .HasColumnName("skill_name");
            });

            modelBuilder.Entity<StepSkill>(entity =>
            {
                entity.ToTable("step_skill", "testultimcurs");

                entity.HasIndex(e => e.Skillid, "skillid");

                entity.HasIndex(e => e.Stepid, "stepid");

                entity.Property(e => e.StepskillId).HasColumnName("stepskill_id");

                entity.Property(e => e.Skillid).HasColumnName("skillid");

                entity.Property(e => e.Stepid).HasColumnName("stepid");
            });

            modelBuilder.Entity<Technology>(entity =>
            {
                entity.HasKey(e => e.Idtechnology)
                    .HasName("PK_technology_idtechnology");

                entity.ToTable("technology", "testultimcurs");

                entity.Property(e => e.Idtechnology)
                    .ValueGeneratedNever()
                    .HasColumnName("idtechnology");

                entity.Property(e => e.TechCategory)
                    .HasMaxLength(45)
                    .HasColumnName("tech_category");

                entity.Property(e => e.TechName)
                    .HasMaxLength(45)
                    .HasColumnName("tech_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
