using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class ReviewConfiguration : BaseEntityConfiguration<Guid, Review>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Review> builder)
        {
            builder
                .Property(review => review.Title)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(review => review.Content)
                .IsRequired();

            builder
                .Property(review => review.Rating)
                .IsRequired();

            builder
                .HasCheckConstraint("CK_VALID_RATING", $"[{nameof(Review.Rating)}] BETWEEN 0 and 10");

            builder
                .Property(review => review.HasSpoilers)
                .HasDefaultValue(false);

            builder
                .Property(review => review.Recommended)
                .ValueGeneratedNever()
                .HasDefaultValue(true);
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasMany(review => review.Comments)
                .WithOne(comment => comment.Review)
                .HasForeignKey(comment => comment.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .IsRequired();

            builder
                .HasOne(review => review.Media)
                .WithMany(media => media.Reviews)
                .HasForeignKey(review => review.MediaId)
                .HasPrincipalKey(media => media.Id)
                .IsRequired();

            builder
                .HasOne(review => review.OriginalPoster)
                .WithMany(user => user.Reviews)
                .HasForeignKey(review => review.OriginalPosterId)
                .HasPrincipalKey(user => user.Id)
                .IsRequired();

            builder
                .HasIndex(review => new { review.MediaId, review.OriginalPosterId })
                .IsUnique();

            builder
                .HasMany(review => review.ReviewOpinions)
                .WithOne(reviewOpinion => reviewOpinion.Review)
                .HasForeignKey(reviewOpinion => reviewOpinion.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<Review> builder)
        {
            builder
                .ToTable($"{nameof(Review)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasData(new List<Review>()
                {
                    new Review()
                    {
                        Id = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        OriginalPosterId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        Title = "Expect the unexpected",
                        Content = @"Fractured is a mystery thriller, I'd agree with that, but the one tag that's missing, is surreal. It's a very odd film, so odd it's almost bonkers,
                                    it's like being in a nightmare, you can't wake up, all events are out of your control, and every aspect of life is spiraling out of control. 
                                    I won't give a single spoiler away, because it would give the game away, all I could say is expect the unexpected. 
                                    I predicted events and outcomes, I got every single sequence of events wrong, loaded with twists and crammed full of intrigue. Sam Worthington is terrific.
                                    It's trippy, it's slow to start, but great as it gets going, think The Lady vanishes. 7/10",
                        Rating = 7.0f,
                        HasSpoilers = false,
                        Recommended = true,
                    },
                    new Review()
                    {
                        Id = Guid.Parse("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        OriginalPosterId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        Title = "A mind of its own",
                        Content = @"When a movie decides to go places, as a viewer you have the choice to ride with it or abandon it.
                                    I do hope you are taking option A and ride with it. It really is quite engaging and you will be quite
                                    'mindblown' as another reviewer already rightfully stated. If you were wondering where Sam Worthington was (is) - wonder no more.
                                    This is really a nice acting piece he got to grab and make something of it.
                                    There are 2 obvious paths or choices or options, on how to view this or what it probably is telling us. So no Bonus points for guessing right.
                                    This is about the journey and it is quite an exhausting one! But very good too",
                        Rating = 8.0f,
                        HasSpoilers = true,
                        Recommended = true,
                    },
                    new Review()
                    {
                        Id = Guid.Parse("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        OriginalPosterId = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        Title = "Fracture",
                        Content = "For a surprise worhington isnt stoic in this film but film potential could be used in better way and ending isnt very good",
                        Rating = 4.0f,
                        HasSpoilers = false,
                        Recommended = false,
                    },
                    new Review()
                    {
                        Id = Guid.Parse("a2862e81-a1ff-4084-90dd-ce8827ce27e2"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        OriginalPosterId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        Title = "Only the end is okay, the rest is below average",
                        Content = @"I have to admit I am disappointed by this movie. I saw it had a high rating and I read some reviews about how good it was supposed to be. But in fact it's not that great. 
                                    It could have been so much better if they would not have dragged that whole story. By that I mean the only last half hour could be qualified as good. The rest of the movie is a battle to not fall asleep, with unstoppable irritating 
                                    conversations between a bunch of weirdo's. If it was not for the end, that you see coming from miles away by the way, then I would have scored the movie even lesser. The actors are not bad, they are just average. Anyways, 
                                    if other people like The Invitation, good for them, but it was not my cup of tea.",
                        Rating = 5.0f,
                        HasSpoilers = false,
                        Recommended = false,
                    },
                    new Review()
                    {
                        Id = Guid.Parse("2fe24bcb-afa2-42df-bf28-5ea04172e783"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        OriginalPosterId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        Title = "It's weird, but it's L.A.",
                        Content = @"Will (Logan Marshall-Green) and Kira (Emayatzy Corinealdi) have accepted a fancy dinner invitation (the invitation was fancy not the dinner) to the 
                                    house that he formally lived in. His ex-wife Eden (Tammy Blanchard) and her new husband David (Michiel Huisman) are hosting. Many couples show up, 
                                    all friends of Eden. Eden and Dave have spent the last two years in Mexico. 
                                    About 30 minutes into the film two more plot details fill in. Will and Eden had a son that died. Eden was in Mexico being part of a cult that helped her get over 
                                    her grief knowing she will be with her loves ones in the afterlife. Will suffers from the loss of his child and has bad memories.
                                    Will suspects something is going on, but everyone else doesn't see it. As the audience we find the explanations acceptable, and Will maybe has issues...or not. We don't know 
                                    but soon the pieces come together when in end...when we finally decide we were actually entertained, but didn't know it as the film moves slow.
                                    Michelle Krusiec is the token hot Asian chick.
                                    Guide: F - word.No sex or nudity.",
                        Rating = 8.0f,
                        HasSpoilers = true,
                        Recommended = true,
                    },
                });
        }
    }
}
